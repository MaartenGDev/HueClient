using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HueClient
{
    class HttpClient
    {
        private HueUser User;

        public HttpClient(HueUser user)
        {
            User = user;
        }

        public String Get(String uri)
        {
            WebRequest request = WebRequest.Create(uri);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);

            string responseFromServer = reader.ReadToEnd();

            reader.Close();
            dataStream.Close();
            response.Close();

            return responseFromServer;
        }

        public String Put(String uri, String data)
        {
            using (var client = new System.Net.WebClient())
            {
                return client.UploadString(uri, "PUT",data);
            }
        }
        public HueUser getUser()
        {
            return User;
        }
    }
}