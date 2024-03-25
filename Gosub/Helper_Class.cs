using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Gosub
{
   public  static class Helper_Class
    {
      
        public  static   JToken Json_Responce(string Containt)
        {
            StringReader reader = new StringReader(Containt);
            using (JsonReader jsonReader = new JsonTextReader(reader))
            {
                JsonSerializer Deserializer = new JsonSerializer();
                return (JToken)Deserializer.Deserialize<JToken>(jsonReader);
            }
        }
        public static  async Task<IRestResponse> Send_Request(string url, Method _Method, List<Tuple<string, string>> QueryParameters = null, string Request_Payload = null)
        {


            var P_client = new RestClient(url);
            var P_request = new RestRequest(_Method);

            if (QueryParameters != null)
            {
                foreach (Tuple<string, string> i in QueryParameters)
                {
                    P_request.AddQueryParameter(i.Item1, i.Item2);
                }
            }

            if(Request_Payload!= null)
            {
                P_request.AddJsonBody(Request_Payload);
            }

            P_request.AddHeader("Accept", "application/json");
            P_request.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/100.0.4896.127 Safari/537.36 Edg/100.0.1185.50");
            P_request.AddHeader("X-RPS-Client-App-Version", "242/2022-03-29T12:00:42.449Z/release/2022-03-29/prd01/kr01/bc2b6b69fe9ab6174c59ec118b093b5f729a3087");
            P_request.AddHeader("X-RPS-Client-App-Name", "GoWeb");
            P_request.AddHeader("x-rps-client-app-wrapper-type", "WEB");
            P_request.AddHeader("x-rps-client-app-wrapper-version", "WEB-NA");
            //P_request.AddHeader("x-rps-device", "WEB|c5b747d1-fa7a-48ce-8f9f-b1117*******");
            P_request.AddHeader("x-rps-device", "WEB|bbc61e85-9e8c-4e0e-9b91-e37db*******");
            P_request.AddHeader("sec-ch-ua-platform", "Windows");
            P_request.AddHeader("Origin", "https://web.rpsyogiyo.io");
            P_request.AddHeader("Accept-Language", "en"); // en-US,en;q=0.9
            P_request.AddHeader("Sec-Fetch-Site", "same-site");
            P_request.AddHeader("Sec-Fetch-Mode", "cors");
            P_request.AddHeader("Sec-Fetch-Dest", "empty");
            P_request.AddHeader("Referer", "https://web.rpsyogiyo.io/");
            P_request.AddHeader("authorization", Properties.Settings.Default.AccessToken);
            //P_request.AddHeader("accept-encoding","")
                //P_request.enc


            IRestResponse _result = await Task.Run(() => P_client.ExecuteAsync(P_request));
            return _result;

        }

    }
}
