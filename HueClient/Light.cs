using Newtonsoft.Json;
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

        public Light(HttpClient http, String id, String name)
        {
            Http = http;
            Id = id;
            Name = name;
        }

        public void SetHue(int hue)
        {
            HueUser user = Http.getUser();

            String apiToken = user.Token;
            String apiHost = user.Host;

            LightState lightState = new LightState();
            lightState.hue = hue;
            lightState.bri = 100;
            lightState.sat = 100;

            String jsonState = JsonConvert.SerializeObject(lightState);
            Console.WriteLine(jsonState);

            String state = Http.Put($"http://{apiHost}/api/{apiToken}/lights/{Id}/state", jsonState);

            //Console.WriteLine(state);
        }
    }
}
