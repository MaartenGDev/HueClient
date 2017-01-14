using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HueClient
{
    class Hue
    {
        private HttpClient Http;
        private HueUser User;
        private Lights Lights;

        public Hue(HttpClient http, HueUser user)
        {
            Http = http;
            User = user;
        }

        public Lights AllLights()
        {
            String apiToken = User.Token;
            String apiHost = User.Host;

            String response = Http.Get($"http://{apiHost}/api/{apiToken}/lights");

 
            JObject allTracks = JObject.Parse(response);

            Console.WriteLine(allTracks);

            return Lights;
        }
    }
}