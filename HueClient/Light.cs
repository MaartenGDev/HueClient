using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HueClient
{
    class Light
    {
        public String Name;
        public String Id;
        public LightState State;
        public HttpClient Http;
        public Light(HttpClient http, String id,String name, LightState state)
        {
            Http = http;
            Id = id;
            Name = name;
            State = state;
        }

        public void SetHue(int value)
        {
            HueUser user = Http.getUser();

            String apiToken = user.Token;
            String apiHost = user.Host;

            JObject o = new JObject();

            String state = Http.Put($"http://{apiHost}/api/{apiToken}/lights/{Id}/state", "{\"bri\":42}");

            Console.WriteLine(state);
        }
    }
}
