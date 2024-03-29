using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Data.SqlTypes;


namespace Gosub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.CellDoubleClick += DataGridView1_CellDoubleClick;
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        { 
            string id = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            Thread th = new Thread(new ThreadStart(() =>
            {
                Task<IRestResponse> tx = Task.Run(() => Helper_Class.Send_Request("https://crs.rpsyogiyo.io/api/1/deliveries/" + id, Method.GET, null));
                tx.Wait();
                this.Invoke(new Action(() => {

                    if (!string.IsNullOrEmpty(tx.Result.Content))
                    {


                        JToken o = Helper_Class.Json_Responce(tx.Result.Content.ToString());
                        if (tx.Result.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            Order_Detail_frm order_Detail_Frm = new Order_Detail_frm();
                            if (o["transport"]["type"].ToString() == "RESTAURANT_DELIVERY")
                            {
                                order_Detail_Frm.tabControl1.TabPages.Remove(order_Detail_Frm.deliverinfoPage);
                                order_Detail_Frm.deliverType.Text = "가게배달";
                                order_Detail_Frm.deliveryType.Text = "가게배달";
                            }
                            else
                            {
                                order_Detail_Frm.deliverType.ForeColor = Color.Red;
                                order_Detail_Frm.deliverType.Text = "요기배달";
                                order_Detail_Frm.deliveryType.Text = "요기배달(실속)";
                                if(o["transport"]["acceptedAt"] == null)
                                {
                                    order_Detail_Frm.progressBar1.Value = 0;
                                    order_Detail_Frm.assignTime.Text = "00:00";
                                }
                                else
                                {
                                    order_Detail_Frm.progressBar1.Value = 10;
                                    order_Detail_Frm.assignTime.Text = ConvertAndFormatTime2(o["transport"]["acceptedAt"].ToString());
                                }
                                if (o["transport"]["dispatchedAt"] == null)
                                {
                                    order_Detail_Frm.pickupTime.Text = "00:00";
                                }
                                else
                                {
                                    order_Detail_Frm.progressBar1.Value = 60;
                                    order_Detail_Frm.pickupTime.Text = ConvertAndFormatTime2(o["transport"]["dispatchedAt"].ToString());
                                }
                                if (o["transport"]["dispatchedAt"] == null)
                                {
                                    order_Detail_Frm.deliverTime.Text = "00:00";
                                }
                                else
                                {
                                    order_Detail_Frm.progressBar1.Value = 100;
                                    order_Detail_Frm.deliverTime.Text = ConvertAndFormatTime2(o["transport"]["deliveredAt"].ToString());
                                }
                            }
                            order_Detail_Frm.orderShortCode.Text = "#" + o["shortCode"].ToString();
                            order_Detail_Frm.orderStatus.Text = o["state"].ToString();
                            JToken menus = o["items"];
                            int count = 0;
                            foreach (JToken item in menus)
                            {
                                count++;
                                FlowLayoutPanel Items = new FlowLayoutPanel();
                                Items.FlowDirection = FlowDirection.TopDown;
                                Items.MinimumSize = new Size(order_Detail_Frm.menu_Items.Width - 27, 25);


                                Panel pn = new Panel() { Size = new Size(Items.Width, 25) };
                                Label I_name = new Label() { Text = item["name"].ToString() + "*" + item["amount"].ToString(), Location = new Point(16, 0), Width = 300};
                                Label I_subTotalPrice = new Label() { TextAlign = ContentAlignment.MiddleRight, Text = item["total"].ToString() + "원", Location = new Point(Items.Right - 120, 0) };

                                pn.Controls.Add(I_name);
                                pn.Controls.Add(I_subTotalPrice);

                                Items.Controls.Add(pn);

                                foreach (JToken I_options in item["modifiers"])
                                {
                                    Panel pn1 = new Panel() { Size = new Size(Items.Width, 25) };
                                    Label I_optionName = new Label() { Text = I_options["name"].ToString() + "*" + I_options["amount"].ToString(), Location = new Point(30, 0), Width = 300};
                                    Label I_optionPrice = new Label() { TextAlign = ContentAlignment.MiddleRight, Text = "+" + I_options["total"].ToString() + "원", Location = new Point(Items.Right - 120, 0) };


                                    pn1.Controls.Add(I_optionName);
                                    pn1.Controls.Add(I_optionPrice);

                                    Items.Controls.Add(pn1);
                                }

                                Items.AutoSize = true;
                                Items.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                                order_Detail_Frm.menu_Items.Controls.Add(Items);
                            }
                            foreach (JToken fee in o["fees"])
                            {
                                FlowLayoutPanel Items = new FlowLayoutPanel();
                                Items.FlowDirection = FlowDirection.TopDown;
                                Items.MinimumSize = new Size(order_Detail_Frm.menu_Items.Width - 27, 25);

                                Panel pn2 = new Panel() { Size = new Size(Items.Width, 25) };
                                Label FeeName = new Label() { Text = fee["name"].ToString(), Location = new Point(16, 0), Width = 300 };
                                Label FeePrice = new Label() { TextAlign = ContentAlignment.MiddleRight, Text = fee["value"].ToString() + "원", Location = new Point(Items.Right - 120, 0) };

                                pn2.Controls.Add(FeeName);
                                pn2.Controls.Add(FeePrice);
                                Items.Controls.Add(pn2);
                                Items.AutoSize = true;
                                Items.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                                order_Detail_Frm.menu_Items.Controls.Add(Items);
                            }
                            order_Detail_Frm.totalMenuCount.Text = count.ToString();
                            order_Detail_Frm.totalPrice.Text = o["payment"]["total"].ToString() + "원";

                            string[] comment = o["comment"].ToString().Split('/');
                            order_Detail_Frm.storeRequest.Text = string.Join(" / ", comment, 0, comment.Length - 1).Trim();
                            order_Detail_Frm.riderRequest.Text = o["requirements"]["commentToRider"].ToString();

                            order_Detail_Frm.customerPhone.Text = o["customer"]["phone"].ToString();
                            order_Detail_Frm.storeName.Text = o["vendorName"].ToString();
                            order_Detail_Frm.orderNumber.Text = o["externalId"].ToString();
                            order_Detail_Frm.orderTime.Text = ConvertAndFormatTime1(o["timestamp"].ToString());
                            string address = o["address"]["street"].ToString();
                            if(address.Length > 20)
                            {
                                order_Detail_Frm.deliverAddress.Text = address.Substring(0, 20) + "...";
                            }
                            else
                            {
                                order_Detail_Frm.deliverAddress.Text = address;
                            }

                            order_Detail_Frm.orderShortInfo.Text = string.Format("메뉴{0}개 {1}원 {2}", count, o["payment"]["total"].ToString(), o["payment"]["paymentMethod"].ToString());
                            order_Detail_Frm.ShowDialog();
                        }
                    }   
                }));

            }));
            th.Start();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //FromDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day - 1); //bug here
            //ToDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 1);
            //Order_Viewer frm = new Order_Viewer();
            //frm.Show(this);


            //ToDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.AddDays(1).Day);

            FromDate.Value = DateTime.Now.AddDays(-1);
            ToDate.Value = DateTime.Now.AddDays(1);
            //foreach (DataGridViewColumn c in this.dataGridView1.Columns)
            //{
            //    c.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            //}

            Load_Config();

            //Getrestaurants();



            //this.button3.Enabled = true;
            //MessageBox.Show(_result.ResponseStatus.ToString());


            //Restaurants.Controls.Add(new Restaurants_Controls.Restaurant_Item() { R_name = "Test 1" , R_status = "OPEN" });
            //Restaurants.Controls.Add(new Restaurants_Controls.Restaurant_Item() { R_name = "Test 2", R_status = "OPEN" });
            //Restaurants.Controls.Add(new Restaurants_Controls.Restaurant_Item() { R_name = "Test 3", R_status = "OPEN" });
        }

        private string platformKey ;
        private List<string> closingReasons = new List<string>();
        private List<int> closingMinutes = new List<int>();

        public void Load_Config()
        {
            Thread th = new Thread(new ThreadStart(() =>
            {
                Task<IRestResponse> tx = Task.Run(() => Helper_Class.Send_Request("https://crs.rpsyogiyo.io/api/1/platforms/config/availabilities", Method.GET));
                
                tx.Wait();

                if (!string.IsNullOrEmpty(tx.Result.Content))
                {


                    JToken o = Helper_Class.Json_Responce(tx.Result.Content.ToString());



                   
                    //if (_result.IsSuccessful == true)
                    if (tx.Result.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        closingMinutes.Clear();

                        foreach (JToken x in o.First().SelectToken ("closingMinutes"))
                        {
                            closingMinutes.Add(int.Parse(x.ToString()));
                        }

                        closingReasons.Clear();
                        foreach (JToken x in o.First().SelectToken("closingReasons"))
                        {
                            closingReasons.Add(x.ToString());
                        }

                        platformKey = o.First().SelectToken("platformKey").ToString ();

                        Getrestaurants();
                    }
                    else
                    {
                        if (o.SelectToken("message") != null)
                        {
                           this.Invoke(new Action(() =>
                           {

                           
                                MessageBox.Show(this, o.SelectToken("message").ToString(), o.SelectToken("code").ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                                if (o.SelectToken("code").ToString() == "unauthorized-error")
                                {
                               
                                    Login_frm frm = new Login_frm();
                                    frm.ShowDialog(this);

                                }
                           }));
                        }

                    }
                  



                    //this.Status.Text = tx.Result.StatusDescription.ToString();
                }


                //Status.Text = tx.Result.ResponseStatus.ToString();


            }));
            th.Start();

        }



        private void button3_Click(object sender, EventArgs e)
        {
           
            switch (this.button3.Text)
            {
                case "Get Orders":
                    if (checkBox2.Checked == true)
                    {

                        int minutes = int.Parse(waiter.Text);

                        order_new.Checked = true;
                        if (minutes >= 1)
                        {
                            this.button3.Text = "Stop";
                            this.timer1.Interval = minutes * 60000;
                            this.timer1.Enabled = true;
                        }
                       
                    }
                    else
                    {
                        this.button3.Enabled = false;

                       
                            //GetOrder((string)f);
                         GetOrder();

                        
                    }

                    foreach (RadioButton c in panel1.Controls)
                    {
                        if (c.Checked == true)
                        {
                            Properties.Settings.Default.Order_FILTERS = c.Name;
                            
                        }
                    }
                    Properties.Settings.Default.Auto_Check = this.checkBox2.Checked;
                    Properties.Settings.Default.Auto_Check_Value=  this.waiter.Text  ;

                    if(this.Auto_Save_Data.Enabled == true)
                    {
                        Properties.Settings.Default.Auto_Save = this.Auto_Save_Data.Checked;
                    }
                  

                    Properties.Settings.Default.Save();

                    //Properties.Settings.Default.Order_FILTERS = this.order_nofilter;
                    break;

                case "Stop":
                    this.button3.Text = "Get Orders";
                    this.timer1.Enabled = false;
                    break;
            }
         
           
        }

        public  void GetOrder()
        {
            //List<KeyValuePair<string, string>> QueryParameters = new List<KeyValuePair<string, string>>();

            var QueryParameters = new List< Tuple<string, string> >();

            //var duplicatedDictionaryExample = new List<(string Key, string Value)> { ("", "")... }

         

           

            //var P_client = new RestClient("https://crs.rpsyogiyo.io/api/2/deliveries?from=2022-04-23T22%3A00%3A00.000Z&statuses=EXPIRED&to=2022-04-24T21%3A59%3A59.999Z");


        
            QueryParameters.Add(new Tuple<string, string>("from", this.FromDate.Value.ToString("yyyy-MM-dd") + "T12:14:20.073Z"));

            if (order_accepted.Checked == true)
            {
                 QueryParameters.Add(new Tuple<string, string>("statuses", "ACCEPTED"));
                 QueryParameters.Add(new Tuple<string, string>("statuses", "PREORDER_ACCEPTED"));
            }

            if(order_new.Checked == true)
            {
                QueryParameters.Add(new Tuple<string, string>("statuses", "NEW"));
                QueryParameters.Add(new Tuple<string, string>("statuses", "CANCELLED_BY_TRANSPORT"));
                QueryParameters.Add(new Tuple<string, string>("statuses", "CANCELLED_BY_PLATFORM"));
                QueryParameters.Add(new Tuple<string, string>("statuses", "CANCELLED"));
            }

            if(order_expired.Checked == true)
            {
                 QueryParameters.Add(new Tuple<string, string>("statuses", "EXPIRED"));
            }

            if (orders_recent.Checked == true)
            {
                QueryParameters.Add(new Tuple<string, string>("statuses", "CANCELLED"));
                QueryParameters.Add(new Tuple<string, string>("statuses", "CANCELLED_BY_PLATFORM"));
                QueryParameters.Add(new Tuple<string, string>("statuses", "CANCELLED_BY_TRANSPORT"));
                QueryParameters.Add(new Tuple<string, string>("statuses", "CLOSED"));
                QueryParameters.Add(new Tuple<string, string>("statuses", "EXPIRED"));
                QueryParameters.Add(new Tuple<string, string>("statuses", "INITIALIZING"));
                QueryParameters.Add(new Tuple<string, string>("statuses", "MISSED"));
                QueryParameters.Add(new Tuple<string, string>("statuses", "REJECTED"));
                QueryParameters.Add(new Tuple<string, string>("statuses", "WAITING_FOR_TRANSPORT"));

            }



             QueryParameters.Add(new Tuple<string, string>("to", this.ToDate.Value.ToString("yyyy-MM-dd") + "T12:14:20.073Z"));



            Thread th = new Thread(new ThreadStart(() =>
            {
                Task<IRestResponse> tx = Task.Run(() => Helper_Class.Send_Request("https://crs.rpsyogiyo.io/api/2/deliveries?", Method.GET,QueryParameters));
                //Task<IRestResponse> tx = Getrestaurants().RunSynchronously();
                tx.Wait();
                this.Invoke(new Action(() => {
                    this.dataGridView1.Rows.Clear();

                    if (!string.IsNullOrEmpty(tx.Result.Content))
                    {


                        JToken o = Helper_Class.Json_Responce(tx.Result.Content.ToString());


                     
                        //if (_result.IsSuccessful == true)
                        if (tx.Result.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            int count = 0;
                            foreach (JToken x in o)
                            {
                                count++;
                                DataGridViewRow r = new DataGridViewRow();

                                r.Tag = x.SelectToken("id");

                                string str1 = x.SelectToken("shortCode") != null ? x.SelectToken("shortCode").ToString() : "";
                                string str2 = x.SelectToken("vendorName") != null ? x.SelectToken("vendorName").ToString() : "";
                                string str3 = x["address"]["street"] != null ? x["address"]["street"].ToString() : "";
                                string str4 = x["customer"]["phone"] != null ? x["customer"]["phone"].ToString() : "";
                                string str5 = x["items"][0]["comment"] != null ? x["items"][0]["comment"].ToString() : "";
                                string str6 = x["items"][0]["name"] != null ? x["items"][0]["name"].ToString() : "";
                                string str7 = x["items"][0]["amount"] != null ? x["items"][0]["name"].ToString() : "";
                                string str8 = x["items"][0]["price"] != null ? x["items"][0]["name"].ToString() : "";
                                string str9 = "";
                                string str10 = "";
                                if (x["fees"].Count() != 0)
                                {
                                    str9 = x["fees"] != null ? x["fees"][0]["name"].ToString() : "";
                                    str10 = x["fees"] != null ? x["fees"][0]["value"].ToString() : "";
                                }
                                string str11 = x["payment"]["total"] != null ? x["payment"]["total"].ToString() : "";
                                string str12 = x["payment"] != null ? x["payment"]["paymentMethod"].ToString() : "";
                                string str13 = x["acceptedAt"] != null ? x["acceptedAt"].ToString() : "";
                                string str14 = x["accepter"] != null ? x["accepter"].ToString() : "";
                                string str15 = x["deliverAt"] != null ? x["deliverAt"].ToString() : "";
                                string str16 = x["expiresAt"] != null ? x["expiresAt"].ToString() : "";
                                string str17 = x["promisedTime"] != null ? x["promisedTime"].ToString() : "";
                                string str18 = x["seenAt"] != null ? x["seenAt"].ToString() : "";
                                string str19 = x["timestamp"] != null ? x["timestamp"].ToString() : "";
                                string str20 = x["state"] != null ? x["state"].ToString() : "";
                                string str21 = x["id"].ToString();

                                r.Cells.Add(new DataGridViewTextBoxCell() { Value = str1 });
                                r.Cells.Add(new DataGridViewTextBoxCell() { Value = str2 });
                                r.Cells.Add(new DataGridViewTextBoxCell() { Value = str3 });
                                r.Cells.Add(new DataGridViewTextBoxCell() { Value = str4 });
                                r.Cells.Add(new DataGridViewTextBoxCell() { Value = str5 });
                                r.Cells.Add(new DataGridViewTextBoxCell() { Value = str6 });
                                r.Cells.Add(new DataGridViewTextBoxCell() { Value = str7 });
                                r.Cells.Add(new DataGridViewTextBoxCell() { Value = str8 });
                                r.Cells.Add(new DataGridViewTextBoxCell() { Value = str9 });
                                r.Cells.Add(new DataGridViewTextBoxCell() { Value = str10 });
                                r.Cells.Add(new DataGridViewTextBoxCell() { Value = str11 });
                                r.Cells.Add(new DataGridViewTextBoxCell() { Value = str12 });
                                r.Cells.Add(new DataGridViewTextBoxCell() { Value = str13 });
                                r.Cells.Add(new DataGridViewTextBoxCell() { Value = str14 });
                                r.Cells.Add(new DataGridViewTextBoxCell() { Value = str15 });
                                r.Cells.Add(new DataGridViewTextBoxCell() { Value = str16 });
                                r.Cells.Add(new DataGridViewTextBoxCell() { Value = str17 });
                                r.Cells.Add(new DataGridViewTextBoxCell() { Value = str18 });
                                r.Cells.Add(new DataGridViewTextBoxCell() { Value = str19 });
                                r.Cells.Add(new DataGridViewTextBoxCell() { Value = str20 });
                                r.Cells.Add(new DataGridViewTextBoxCell() { Value = str21 });

                                //if (x["items"] != null)
                                //{
                                //    DataGridViewComboBoxCell c = new DataGridViewComboBoxCell();
                                //    foreach (JToken it in x["items"])
                                //    {
                                //        c.Items.Add(it["name"].ToString());
                                //    }
                                //    r.Cells.Add(c);
                                //}

                               



                                if (Auto_Save_Data.Checked == true)
                                {
                                    SqlCommand cmd = new SqlCommand(@"
                            BEGIN
                                IF NOT EXISTS (SELECT * FROM Orders_Table 
                                                WHERE [shortCode] = @str1
                                                AND [vendorName] = @str2
                                                AND [timestamp] = @str19
                                                )
                                BEGIN
                                    INSERT INTO Orders_Table  ([shortCode] ,[vendorName] ,[street],[phone],[comment] ,[name] ,[amount]   ,[price] ,[fees_name]  ,[fees_value] ,[Total] ,[paymentMethod] ,[acceptedAt] ,[accepter] ,[deliverAt] ,[expiresAt] ,[promisedTime]  ,[seenAt] ,[timestamp] ,[state])
                                    VALUES (@str1, @str2, @str3,  @str4, @str5, @str6, @str7, @str8, @str9, @str10, @str11, @str12, @str13, @str14, @str15, @str16, @str17, @str18, @str19, @str20)
                                END
                            END
                            ", Program.db);
                                    cmd.Parameters.AddWithValue("@str1", str1);
                                    cmd.Parameters.AddWithValue("@str2", str2);
                                    cmd.Parameters.AddWithValue("@str3", str3);
                                    cmd.Parameters.AddWithValue("@str4", str4);
                                    cmd.Parameters.AddWithValue("@str5", str5);
                                    cmd.Parameters.AddWithValue("@str6", str6);
                                    cmd.Parameters.AddWithValue("@str7", str7);
                                    cmd.Parameters.AddWithValue("@str8", str8);
                                    cmd.Parameters.AddWithValue("@str9", str9);
                                    cmd.Parameters.AddWithValue("@str10", str10);
                                    cmd.Parameters.AddWithValue("@str11", str11);
                                    cmd.Parameters.AddWithValue("@str12", str12);
                                    cmd.Parameters.AddWithValue("@str13", str13);
                                    cmd.Parameters.AddWithValue("@str14", str14);
                                    cmd.Parameters.AddWithValue("@str15", str15);
                                    cmd.Parameters.AddWithValue("@str16", str16);
                                    cmd.Parameters.AddWithValue("@str17", str17);
                                    cmd.Parameters.AddWithValue("@str18", str18);
                                    cmd.Parameters.AddWithValue("@str19", str19);
                                    cmd.Parameters.AddWithValue("@str20", str20);


                                    cmd.ExecuteNonQuery();
                                }

                                if (str20 == "NEW")
                                {
                                    Order_Viewer v = new Order_Viewer();
                                    v.order_ID = r.Tag.ToString();
                                    v.Order_No.Text  = str1;

                                    

                                    if (x["items"] != null)
                                    {
                                       
                                        foreach (JToken it in x["items"])
                                        {
                                            Controls.Order_Item O_Item = new Controls.Order_Item();
                                           

                                            O_Item.O_Title.Text = it["menuNumber"] != null ? it["menuNumber"].ToString() : ""
                                            +  it["name"] != null ? "-" + it["name"].ToString():"";



                                            O_Item.O_category.Text = it["category"] != null ? "(" + it["category"].ToString() + ")" : "";
                                            O_Item.comment.Text = it["comment"] != null ? it["comment"].ToString() : "";




                                            if (it["modifiers"] != null)
                                            {

                                                foreach (JToken M in it["modifiers"])
                                                {
                                                    Controls.O_modifier M_I = new Controls.O_modifier();
                                                    M_I.M_Name.Text = M["name"] != null ? M["name"].ToString() : "";
                                                    M_I.M_Amount.Text = M["amount"] != null ? M["amount"].ToString() : "";
                                                    M_I.M_Price.Text = M["total"] != null ? M["total"].ToString() : "";

                                                    
                                                    


                                                    O_Item.O_modifiers.Controls.Add(M_I);
                                                }

                                            }
                                            
                                            

                                            O_Item.O_Amount.Text = it["amount"] != null ? it["amount"].ToString() : "";
                                            O_Item.O_Price.Text = it["total"] != null ? it["total"].ToString() : "";


                                            v.Order_Items.Controls.Add(O_Item);
                                        }
                                      
                                    }



                                    v.Total.Text  = str11;
                                    v.Collect_from_customer.Text = x["payment"]["collectAtDropoff"] != null ? x["payment"]["collectAtDropoff"].ToString() : ""; ;

                                    v.V_Name.Text  = str2;
                                    v.Owner = this;
                                    v.Show(this);
                                }
                                this.dataGridView1.Rows.Add(r);

                            }
                        }
                        else
                        {
                            if (o.SelectToken("message") != null)
                            {
                                MessageBox.Show(this, o.SelectToken("message").ToString(), o.SelectToken("code").ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                                if (o.SelectToken("code").ToString() == "authentication-error")
                                {
                                    this.timer1.Enabled = false;
                                    this.button3.Text = "Get Orders";
                                    Login_frm frm = new Login_frm();
                                    frm.ShowDialog(this);

                                }
                            }

                        }
                        

                        

                        this.Status.Text = tx.Result.StatusDescription.ToString();
                    }

                    if (tx.Result.StatusCode != System.Net.HttpStatusCode.OK)
                    {
                        Status.Text = tx.Result.ResponseStatus.ToString();
                        if (this.button3.Text == "Stop")
                        {
                            this.button3.PerformClick();
                        }


                    }
                    this.button3.Enabled = true;
                    //MessageBox.Show(_result.ResponseStatus.ToString());
                }));

            }));
            th.Start();


               

            
        }



        private  void Getrestaurants()
        {
            //MessageBox.Show(platformKey);
            Thread th = new Thread(new ThreadStart(() =>
            {
                Task<IRestResponse> tx = Task.Run(() => Helper_Class.Send_Request("https://crs.rpsyogiyo.io/api/1/restaurants", Method.GET));
                //Task<IRestResponse> tx = Task.Run(() => Helper_Class.Send_Request("https://crs.rpsyogiyo.io/api/1/restaurants/72863", Method.GET));
                //Task<IRestResponse> tx = Getrestaurants().RunSynchronously();
                tx.Wait();
                if(this.IsDisposed == false)
                {
                    this.Invoke(new Action(() => {
                        this.Restaurants.Controls.Clear();
                        if (!string.IsNullOrEmpty(tx.Result.Content))
                        {


                            JToken o = Helper_Class.Json_Responce(tx.Result.Content.ToString());



                         
                            //if (_result.IsSuccessful == true)
                            if (tx.Result.StatusCode == System.Net.HttpStatusCode.OK)
                            {
                                foreach (JToken x in o.First().SelectToken("platformRestaurants"))
                                {

                                    Restaurants.Controls.Add(new Restaurants_Controls.Restaurant_Item()
                                    {
                                        R_ID = x.SelectToken("id").ToString(),
                                        R_name = x.SelectToken("name").ToString(),
                                        Size = new Size (Restaurants.Width -27,0)

                                    });

                                }
                                if (Restaurants.Controls.Count > 0)
                                {
                                    Restaurants_Availabilities_Status();
                                }

                            }
                            else
                            {
                                if (o.SelectToken("message") != null)
                                {
                                    MessageBox.Show(this, o.SelectToken("message").ToString(), o.SelectToken("code").ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    //MessageBox.Show(o.SelectToken("code").ToString());
                                    if (o.SelectToken("code").ToString() == "UNAUTHORIZED")
                                    {
                                        //this.timer1.Enabled = false;
                                        //this.button3.Text = "Get Orders";
                                        Login_frm frm = new Login_frm();
                                        frm.ShowDialog(this);

                                    }
                                }

                            }
                       



                            this.Status.Text = tx.Result.StatusDescription.ToString();
                        }


                        Status.Text = tx.Result.ResponseStatus.ToString();



                    }));
                }
              
            }));
            th.Start();

        }

      

        private void Restaurants_Availabilities_Status()
        {
          
            Thread th = new Thread(new ThreadStart(() =>
            {
                Task<IRestResponse> tx = Task.Run(() => Helper_Class.Send_Request($"https://crs.rpsyogiyo.io/api/1/platforms/restaurants/availabilities", Method.GET));
                //Task<IRestResponse> tx = Getrestaurants().RunSynchronously();
                tx.Wait();
                if(this.IsDisposed == false)
                {
                    this.Invoke(new Action(() => {


                        if (!string.IsNullOrEmpty(tx.Result.Content))
                        {


                            JToken o = Helper_Class.Json_Responce(tx.Result.Content.ToString());



                            //if (_result.IsSuccessful == true)
                            if (tx.Result.StatusCode == System.Net.HttpStatusCode.OK)
                            {
                                foreach (JToken x in o)
                                {

                                    foreach (Restaurants_Controls.Restaurant_Item r in this.Restaurants.Controls)
                                    {
                                        if (r.R_ID == x.SelectToken("platformRestaurantId").ToString())
                                        {
                                            r.changeable = bool.Parse(x.SelectToken("changeable").ToString());

                                            if (x.SelectToken("availabilityState").ToString() == "CLOSED_UNTIL" && x.SelectToken("closedReason").ToString() == "TOO_BUSY_KITCHEN")
                                            {
                                                r.R_status = "BUSY";
                                            }
                                            else if (x.SelectToken("availabilityState").ToString() == "OPEN")
                                            {
                                                r.R_status = "OPEN";
                                            }else if ( x.SelectToken("availabilityState").ToString() == "CLOSED_TODAY" || x.SelectToken("availabilityState").ToString() == "CLOSED")
                                            {
                                                r.R_status = "CLOSED";
                                            }



                                            

                                            if (r.R_status == "OPEN")
                                            {

                                                r.Status_Buttons.Controls.Clear();

                                                //MessageBox.Show(closingMinutes.Count.ToString());

                                                foreach (int b in closingMinutes) 
                                                //for (int b = 30; b <= 120; b *= 2)
                                                {
                                                    //foreach (int b  in closingMinutes)
                                                    Button b1 = new Button
                                                    {
                                                        Text = $"Set to busy ({b.ToString ()} mins)",
                                                        Size = new Size(r.Width-23, 40),
                                                        Tag = b,
                                                        Image = Properties.Resources.Busy,
                                                        ImageAlign = ContentAlignment.MiddleLeft,
                                                        TextImageRelation = TextImageRelation.Overlay,
                                                        TextAlign = ContentAlignment.MiddleCenter,
                                                    };

                                                    b1.Click += Restaurants_Availability_Set_Busy;
                                                    r.Status_Buttons.Controls.Add(b1);
                                                }

                                    



                                                Button b3 = new Button
                                                {
                                                    Text = "Close for the day",
                                                    Size = new Size(r.Width - 23, 40),
                                                    Image = Properties.Resources.Closed,
                                                    ImageAlign = ContentAlignment.MiddleLeft,
                                                    TextImageRelation = TextImageRelation.Overlay,
                                                    TextAlign = ContentAlignment.MiddleCenter,
                                                };

                                                //b3.Click += Restaurants_Availability_Set_Closed;
                                                b3.Click += Show_Closed_Resons;
                                                r.Status_Buttons.Controls.Add(b3);

                                                if (r.collapsed == false)
                                                {
                                                    r.Height = r.Status_Buttons.Parent.Height + 80;
                                                }


                                            }

                                            if (r.R_status == "BUSY")
                                            {

                                                r.Status_Buttons.Controls.Clear();

                                                Button b1 = new Button
                                                {
                                                    Text = "Re Open",
                                                    Size = new Size(r.Width - 23, 40),
                                                    Image = Properties.Resources.Open,
                                                    ImageAlign = ContentAlignment.MiddleLeft,
                                                    TextImageRelation = TextImageRelation.Overlay,
                                                    TextAlign = ContentAlignment.MiddleCenter,
                                                };
                                                b1.Click += Restaurants_Availability_Set_ReOpen;
                                                r.Status_Buttons.Controls.Add(b1);


                                                Button b2 = new Button
                                                {
                                                    Text = "Close for the day",
                                                    Size = new Size(r.Width - 23, 40),
                                                    Image = Properties.Resources.Closed,
                                                    ImageAlign = ContentAlignment.MiddleLeft,
                                                    TextImageRelation = TextImageRelation.Overlay,
                                                    TextAlign = ContentAlignment.MiddleCenter,
                                                };

                                                //b2.Click += Restaurants_Availability_Set_Closed;
                                                b2.Click += Show_Closed_Resons;

                                                r.Status_Buttons.Controls.Add(b2);



                                                if (r.collapsed == false)
                                                {
                                                    r.Height = r.Status_Buttons.Parent.Height + 80;
                                                }

                                            }

                                            if (r.R_status == "CLOSED" && r.changeable == true )
                                            {

                                                r.Status_Buttons.Controls.Clear();

                                                Button b1 = new Button
                                                {
                                                    Text = "Re Open",
                                                    Size = new Size(r.Width - 23, 40),
                                                    Image = Properties.Resources.Open,
                                                    ImageAlign = ContentAlignment.MiddleLeft,
                                                    TextImageRelation = TextImageRelation.Overlay,
                                                    TextAlign = ContentAlignment.MiddleCenter,
                                                };
                                                b1.Click += Restaurants_Availability_Set_ReOpen;
                                                r.Status_Buttons.Controls.Add(b1);

                                                foreach (int b in closingMinutes)
                                               
                                                {
                                                    //foreach (int b  in closingMinutes)
                                                    Button b2 = new Button
                                                    {
                                                        Text = $"Set to busy ({b.ToString()} mins)",
                                                        Size = new Size(r.Width - 23, 40),
                                                        Tag = b,
                                                        Image = Properties.Resources.Busy,
                                                        ImageAlign = ContentAlignment.MiddleLeft,
                                                        TextImageRelation = TextImageRelation.Overlay,
                                                        TextAlign = ContentAlignment.MiddleCenter,
                                                    };

                                                    b2.Click += Restaurants_Availability_Set_Busy;
                                                    r.Status_Buttons.Controls.Add(b2);
                                                }



                                                if (r.collapsed == false)
                                                {
                                                    r.Height = r.Status_Buttons.Parent.Height + 80;
                                                }

                                            }
                                           
                                        }
                                    }
                                  

                                }
                            }


                            this.Status.Text = tx.Result.StatusDescription.ToString();
                        }


                        Status.Text = tx.Result.ResponseStatus.ToString();




                    }));
                }
               

            }));
            th.Start();

          
        }

        private void Show_Closed_Resons(object sender, EventArgs e)
        {
            REJECT_REASON_frm frm = new REJECT_REASON_frm();
            foreach(string r in closingReasons)
            {
                Button reson = new Button()
                {
                    Text = r.Replace("_", " "),
                    Tag = r,
                    Size = new Size(250, 30) ,
                    Cursor = Cursors.Hand
                };
                reson.Click += Restaurants_Availability_Set_Closed;

                frm.flowLayoutPanel1.Controls.Add(reson);
            }

            frm.Tag  = (Restaurants_Controls.Restaurant_Item)((Button)sender).Parent.Parent.Parent;
            frm.Text = "WHY ARE YOU CLOSED ?";
            frm.ShowDialog(this);

            //Restaurants_Availability_Set_Closed
        }

        //private void Reson_Click(object sender, EventArgs e)
        //{
        //    REJECT_REASON_frm f = (REJECT_REASON_frm)((Button)sender).Parent.Parent;
        //    f.DialogResult  = DialogResult.OK;
        //}

        #region Restaurants Controls Button
        private void Restaurants_Availability_Set_Busy(object sender, EventArgs e)
        {
            Restaurants_Controls.Restaurant_Item Restaurant_Item = (Restaurants_Controls.Restaurant_Item)((Button)sender).Parent.Parent.Parent;

            Restaurant_Item.Enabled = false;
            Thread th = new Thread(new ThreadStart(() =>
            {




                Task<IRestResponse> server_time = Task.Run(() => Helper_Class.Send_Request($"https://crs.rpsyogiyo.io/api/1/platforms/{platformKey}/restaurants/{Restaurant_Item.R_ID}/availability", Method.OPTIONS));
                //Task<IRestResponse> tx = Getrestaurants().RunSynchronously();

                server_time.Wait();

                string Server_Time_str = server_time.Result.Headers.ToList().Find(x => x.Name == "Server-Time").Value.ToString();

                DateTime myDate = DateTime.ParseExact(Server_Time_str, "yyyy-MM-ddTHH:mm:sszz:00", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AdjustToUniversal);

                string New_DateTime = myDate.AddMinutes(int.Parse(((Button)sender).Tag.ToString())).ToString("yyyy-MM-ddTHH:mm:ss") + "." + DateTime.UtcNow.ToString("fff") + "Z";


                JObject request_payload = new JObject();
                request_payload.Add("availabilityState", "CLOSED_UNTIL");
                request_payload.Add("changeable", true);
                request_payload.Add("closedReason", "TOO_BUSY_KITCHEN");
                request_payload.Add("closedUntil", New_DateTime);

                //MessageBox.Show(request_payload.ToString());
                Task<IRestResponse> tx = Task.Run(() => Helper_Class.Send_Request($"https://crs.rpsyogiyo.io/api/1/platforms/YO_KR/restaurants/{Restaurant_Item.R_ID}/availability", Method.PUT, null, request_payload.ToString()));
                //Task<IRestResponse> tx = Getrestaurants().RunSynchronously();
                tx.Wait();
                this.Invoke(new Action(() => {


                    if (!string.IsNullOrEmpty(tx.Result.Content))
                    {

                        //MessageBox.Show(tx.Result.Content.ToString ());
                        JToken o = Helper_Class.Json_Responce(tx.Result.Content.ToString());



                        //if (_result.IsSuccessful == true)
                        if (tx.Result.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            //foreach (JToken x in o)
                            //{

                            Restaurants_Availabilities_Status();

                            //}
                        }


                        //this.Status.Text = tx.Result.StatusDescription.ToString();
                    }
                    Restaurant_Item.Enabled = true;

                    Status.Text = tx.Result.ResponseStatus.ToString();




                }));









                //*----------------



            }));
            th.Start();

        }

        private void Restaurants_Availability_Set_ReOpen(object sender, EventArgs e)
        {
            Restaurants_Controls.Restaurant_Item Restaurant_Item = (Restaurants_Controls.Restaurant_Item)((Button)sender).Parent.Parent.Parent;
            Restaurant_Item.Enabled = false;
            JObject request_payload = new JObject();
            request_payload.Add("availabilityState", "OPEN");
            request_payload.Add("changeable", true);
           

            Task<IRestResponse> tx = Task.Run(() => Helper_Class.Send_Request($"https://crs.rpsyogiyo.io/api/1/platforms/{platformKey}/restaurants/{Restaurant_Item.R_ID}/availability", Method.PUT, null, request_payload.ToString()));
            //Task<IRestResponse> tx = Getrestaurants().RunSynchronously();
            tx.Wait();
            this.Invoke(new Action(() => {


                if (!string.IsNullOrEmpty(tx.Result.Content))
                {

                    //MessageBox.Show(tx.Result.Content.ToString());
                    JToken o = Helper_Class.Json_Responce(tx.Result.Content.ToString());



                    //if (_result.IsSuccessful == true)
                    if (tx.Result.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        //foreach (JToken x in o)
                        //{

                        Restaurants_Availabilities_Status();

                        //}
                    }


                    //this.Status.Text = tx.Result.StatusDescription.ToString();
                }

                Restaurant_Item.Enabled = true;
                Status.Text = tx.Result.ResponseStatus.ToString();




            }));



        }

        private void Restaurants_Availability_Set_Closed(object sender, EventArgs e)
        {

            
            Restaurants_Controls.Restaurant_Item Restaurant_Item = (Restaurants_Controls.Restaurant_Item) ((Button)sender).Parent.Parent.Tag;
            //MessageBox.Show(Restaurant_Item.R_ID.ToString());
            //Restaurants_Controls.Restaurant_Item Restaurant_Item = (Restaurants_Controls.Restaurant_Item)  ((Button)sender).Parent.Parent.Parent;
            Restaurant_Item.Enabled = false;
            JObject request_payload = new JObject();
            request_payload.Add("availabilityState", "CLOSED_TODAY");
            request_payload.Add("changeable", true);
            request_payload.Add("closedReason", ((Button)sender).Tag.ToString()); /*"BAD_WEATHER"*/

            Task<IRestResponse> tx = Task.Run(() => Helper_Class.Send_Request($"https://crs.rpsyogiyo.io/api/1/platforms/{platformKey}/restaurants/{Restaurant_Item.R_ID}/availability", Method.PUT, null, request_payload.ToString()));
            //Task<IRestResponse> tx = Getrestaurants().RunSynchronously();
            tx.Wait();
            this.Invoke(new Action(() => {


                if (!string.IsNullOrEmpty(tx.Result.Content))
                {

                    //MessageBox.Show(tx.Result.Content.ToString());
                    JToken o = Helper_Class.Json_Responce(tx.Result.Content.ToString());



                    //if (_result.IsSuccessful == true)
                    if (tx.Result.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        //foreach (JToken x in o)
                        //{

                        Restaurants_Availabilities_Status();
                        REJECT_REASON_frm frm = (REJECT_REASON_frm)((Button)sender).Parent.Parent;
                        frm.DialogResult = DialogResult.OK;
                        //}
                    }


                    //this.Status.Text = tx.Result.StatusDescription.ToString();
                }

                Restaurant_Item.Enabled = true;
                Status.Text = tx.Result.ResponseStatus.ToString();




            }));



        }
        #endregion



        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            waiter.Enabled = this.checkBox2.Checked;
            label4.Enabled = this.checkBox2.Checked;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //this.button3.Enabled = false;
            //FromDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day - 1);
            //ToDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 1);


            FromDate.Value = DateTime.Now.AddDays(-1);
            ToDate.Value = DateTime.Now.AddDays(1);

           
            //GetOrder((string)f);
            GetOrder();

           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Data_Viewer_frm frm = new Data_Viewer_frm();

           


            frm.Icon = Icon.FromHandle(((Bitmap)imageList1.Images[1]).GetHicon());

            frm.ToDate.Value = this.ToDate.Value;
            frm.FromDate.Value = this.FromDate.Value;

            if(Properties.Settings.Default.Saved_Data_Viewer == "All_Data"){
                frm.All_Data.Checked = true;
            }
            else
            {
                frm.Limited_Data.Checked = true;
            }

            
            frm.Owner = this;
            frm.Show(this);
        }

        private void waiter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Restaurants_Availabilities_Status();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login_frm frm = new Login_frm();
            frm.ShowDialog(this);
        }

        static string ConvertAndFormatTime1(string timeString)
        {
            // Parse the timestamp string into a DateTimeOffset object
            DateTimeOffset kstTime = DateTimeOffset.Parse(timeString);

            // Get the KST time zone
            TimeZoneInfo kstTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Korea Standard Time");

            // Convert KST time to local time
            DateTime localTime = TimeZoneInfo.ConvertTime(kstTime.DateTime, kstTimeZone, TimeZoneInfo.Local);

            // Format the local time using custom formatting
            string formattedTime = localTime.ToString("HH:mm:ss MM'월'dd'일'(ddd)", new System.Globalization.CultureInfo("ko-KR"));

            return formattedTime;
        }

        static string ConvertAndFormatTime2(string timeString)
        {

            // Parse the timestamp string into a DateTimeOffset object
            DateTimeOffset kstTime = DateTimeOffset.Parse(timeString);

            // Get the KST time zone
            TimeZoneInfo kstTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Korea Standard Time");

            // Convert KST time to local time
            DateTime localTime = TimeZoneInfo.ConvertTime(kstTime.DateTime, kstTimeZone, TimeZoneInfo.Local);

            // Format the local time as desired ("오후 1:12")
            string formattedTime = localTime.ToString("tt h:mm", new System.Globalization.CultureInfo("ko-KR"));


            return formattedTime;
        }
    }
}
