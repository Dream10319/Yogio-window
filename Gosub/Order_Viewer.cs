using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gosub
{
    public partial class Order_Viewer : Form
    {
        public string order_ID;
        public Order_Viewer()
        {
            InitializeComponent();
        }

        //Dictionary<string, string> REJECT_REASON ;

        private List<string> Decline_Reasons = new List<string>();

        private void Order_Viewer_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(new ThreadStart(async() =>
            {

                Task<IRestResponse> tx = Task.Run(() => Helper_Class.Send_Request($"https://crs.rpsyogiyo.io/api/1/deliveries/{order_ID}/reasons/reject/restaurant", Method.GET));
                //Task<IRestResponse> tx = Getrestaurants().RunSynchronously();
                tx.Wait();


              

                //var P_client = new RestClient("https://webkick-data.rpsyogiyo.io/i18n/en.json");
                //IRestResponse _result = await Task.Run(() => P_client.ExecuteAsync(P_request));
                //var P_request = new RestRequest(Method.GET);

                if (!string.IsNullOrEmpty(tx.Result .Content))
                {
                    JToken j = Helper_Class.Json_Responce(tx.Result .Content);


                    //JToken resone = j.SelectToken("REJECT_REASON");

                    //MessageBox.Show(resone.ToString());

                    //foreach (JToken resone in j.SelectToken("REJECT_REASON"))
                    //{
                    //    JObject o = (JObject)resone;

                    //    var dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(o.ToString ());

                    //    REJECT_REASON.Add(dict.Keys, dict.Values);
                    //}


                    //var jsonData = JsonConvert.DeserializeObject<Dictionary<string, string>>(j.SelectToken("REJECT_REASON").ToString ());
                    //REJECT_REASON = jsonData;
                    foreach (JObject  keyvalue in j)
                    {

                       
                        this.Invoke(new Action(() =>
                        {

                            //string kk = keyvalue["key"].ToString();
                            //Button x = new Button() { 
                            //    AutoSize = true , 
                            //    Tag = kk,
                            //    Text = kk.Replace("_" , " "),
                            //};
                            //x.Click += X_Click;
                            Decline_Reasons.Add (keyvalue["key"].ToString());

                            //flowLayoutPanel1.Controls.Add(x);
                        }));

                    }
                }



            }));
            th.Start();


            for (int i = 10; i <= 30; i+=5)
            {
                RadioButton bt = new RadioButton()
                {
                    Text = i.ToString(),
                    Tag = i,
                    Size = new Size(40, 40),
                    Appearance = Appearance.Button,
                    FlatStyle = FlatStyle.Flat,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Cursor = Cursors.Hand
                    
                };
                bt.CheckedChanged += Time_CheckedChanged;
                //if (i == 15)
                //{
                //    bt.Checked = true;
                //}

                bt.FlatAppearance.CheckedBackColor = Color.Green;
                bt.FlatAppearance.MouseOverBackColor = Color.LightGreen;

               

               
                Accept_Buttons.Controls.Add(bt);
               


            }
            Accept_Buttons.MinimumSize = new Size( (40 + 3) * 5, 143);
            Accept_Buttons.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void Time_CheckedChanged(object sender, EventArgs e)
        {

            RadioButton r = (RadioButton)sender;

            if(r.Checked == true)
            {
                this.Accept_Button.Text = $"Select cooking time to {r.Tag.ToString()} min";
                this.Accept_Button.Tag = r.Tag;
            }
         
        }

        private void X_Click(object sender, EventArgs e)
        {
            string Resone = ((Button)sender).Tag.ToString();
            //MessageBox.Show(Resone);

            Thread th = new Thread(new ThreadStart(() =>
            {
                JObject x = new JObject();
                x.Add("state", "REJECTED");
                x.Add("reason", Resone );

                Task<RestSharp.IRestResponse> tx = Task.Run(() => Helper_Class.Send_Request($"https://crs.rpsyogiyo.io/api/1/deliveries/{order_ID}/state", RestSharp.Method.PUT, null, x.ToString()));
                //Task<IRestResponse> tx = Getrestaurants().RunSynchronously();

                tx.Wait();

                if (!string.IsNullOrEmpty(tx.Result.Content))
                {
                    JToken j = Helper_Class.Json_Responce(tx.Result.Content);
                    //MessageBox.Show(j.SelectToken("state").ToString());
                    if (j.SelectToken("state").ToString() == "REJECTED")
                    {
                        this.Invoke(new Action(() =>
                        {
                            REJECT_REASON_frm frm = (REJECT_REASON_frm)((Button)sender).Parent.Parent;
                            frm.DialogResult = DialogResult.OK;

                            Form1 f = (Form1)this.Owner;

                            f.GetOrder();

                            this.Dispose();
                        }));
                    }
                }



            }));
            th.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //foreach (var s in REJECT_REASON)
            //{
            //    MessageBox.Show(s.Key, s.Value);
            //}

            Form1 f = (Form1)this.Owner ;

            f.GetOrder();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Decline_Panel.Size = new Size(this.Width - 60, Order_Items.Height);

            //Decline_Panel.Location = new Point(( this.Width - (this.Width - 60 ) )/2, Order_Items.Top);
            //Decline_Panel.Visible = checkBox1.Checked;
            //Decline_Panel.BringToFront();

            REJECT_REASON_frm frm = new REJECT_REASON_frm();
            foreach (string r in Decline_Reasons)
            {
                Button reson = new Button()
                {
                    Text = r.Replace("_", " "),
                    Tag = r,
                    Size = new Size(250 , 30),
                    Cursor = Cursors.Hand
                };
                reson.Click += X_Click;

                frm.flowLayoutPanel1.Controls.Add(reson);
            }

            //frm.Tag = (Restaurants_Controls.Restaurant_Item)((Button)sender).Parent.Parent.Parent;
            frm.Text = "WHY ARE YOU DECLINE ORDER ?";
            frm.ShowDialog(this);

            //Button x = new Button() { 
            //    AutoSize = true , 
            //    Tag = kk,
            //    Text = kk.Replace("_" , " "),
            //};
            //x.Click += X_Click;

        }

        private void Accept_Button_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Accept_Button.Tag.ToString());

           

            Thread th = new Thread(new ThreadStart(() =>
            {
                JObject x = new JObject();
                x.Add("state", "ACCEPTED");
                x.Add("deliveryTime", Accept_Button.Tag.ToString());

                Task<RestSharp.IRestResponse> tx = Task.Run(() => Helper_Class.Send_Request($"https://crs.rpsyogiyo.io/api/1/deliveries/{order_ID}/state", RestSharp.Method.PUT, null, x.ToString()));
                //Task<IRestResponse> tx = Getrestaurants().RunSynchronously();

                tx.Wait();

                if (!string.IsNullOrEmpty(tx.Result.Content))
                {
                    JToken j = Helper_Class.Json_Responce(tx.Result.Content);
                    //MessageBox.Show(j.SelectToken("state").ToString());
                    if (j.SelectToken("state").ToString() == "ACCEPTED")
                    {
                        this.Invoke(new Action(() =>
                        {
                            Form1 f = (Form1)this.Owner;
                            f.GetOrder();

                            this.Dispose();
                        }));
                       
                    }
                }



            }));
            th.Start();
        }
    }
}
