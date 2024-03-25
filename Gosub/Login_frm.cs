using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gosub
{
    public partial class Login_frm : Form
    {
        public Login_frm()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.password.UseSystemPasswordChar = ((CheckBox)(sender)).Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = false;
            Thread th = new Thread(new ParameterizedThreadStart((object f) =>
            {
                SendRequest();

            }));
            th.Start();
        }

        class Request_class
        {

            public string password { get; set; }
            public string username { get; set; }


        }


        public async void SendRequest()
        {
            var P_client = new RestClient("https://crs.rpsyogiyo.io/api/1/auth/form");
            var P_request = new RestRequest(Method.POST);
           

            P_request.AddHeader("Accept", "application/json");
            P_request.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/100.0.4896.127 Safari/537.36 Edg/100.0.1185.50");
            P_request.AddHeader("X-RPS-Client-App-Version", "242/2022-03-29T12:00:42.449Z/release/2022-03-29/prd01/kr01/bc2b6b69fe9ab6174c59ec118b093b5f729a3087");
            P_request.AddHeader("X-RPS-Client-App-Name", "GoWeb");
            P_request.AddHeader("x-rps-client-app-wrapper-type", "WEB");
            P_request.AddHeader("x-rps-client-app-wrapper-version", "WEB-NA");
            //P_request.AddHeader("x-rps-device", "NA");
            P_request.AddHeader("x-rps-device", "WEB|bbc61e85-9e8c-4e0e-9b91-e37db*******");
            P_request.AddHeader("Origin", "https://web.rpsyogiyo.io");
            P_request.AddHeader("Accept-Language", "en"); // en-US,en;q=0.9
            P_request.AddHeader("Sec-Fetch-Site", "same-site");
            P_request.AddHeader("Sec-Fetch-Mode", "cors");
            P_request.AddHeader("Sec-Fetch-Dest", "empty");
            P_request.AddHeader("Referer", "https://web.rpsyogiyo.io/");
          

            P_request.AddJsonBody(new Request_class()
            {

                username = this.username.Text,
                password = this.password.Text,



            }, "application/x-www-form-urlencoded;charset=UTF-8");

          


            IRestResponse _result = await Task.Run(() => P_client.ExecuteAsync(P_request));

            this.Invoke(new Action(() => {
                if (!string.IsNullOrEmpty(_result.Content))
                {
                   

                  
                    StringReader reader = new StringReader(_result.Content.ToString());
                    using (JsonReader jsonReader = new JsonTextReader(reader))
                    {
                        JsonSerializer Deserializer = new JsonSerializer();
                        var o = (JToken)Deserializer.Deserialize<JToken>(jsonReader);


                        this.Invoke(new Action(() =>
                        {

                            if (o.SelectToken("message")!= null)
                            {
                                MessageBox.Show(this,o.SelectToken("message").ToString(), o.SelectToken("code").ToString() , MessageBoxButtons.OK , MessageBoxIcon.Error);

                            }

                            if (o.SelectToken("token") != null)
                            {
                                Properties.Settings.Default.AccessToken = o.SelectToken("tokenType").ToString() + " "+ o.SelectToken("token").ToString();
                                Properties.Settings.Default.Save();
                                MessageBox.Show(this, "Authorization Success", "Authorized", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                ((Form1)this.Owner).Load_Config();
                              

                                this.Dispose();
                            }

                           
                        }));

                    }


                }


                this.button1.Enabled = true;
               
            }));
        }


    }
}
