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

            Lights lightCollection = new Lights();

            IEnumerable<object> lights = JObject.Parse(response);

            foreach(JProperty lightProperty in lights)
            {
                String key = lightProperty.Name;
                JObject light = (JObject)lightProperty.Value;

                JObject state = (JObject)light["state"];
                LightState lightState = new LightState((int) state["bri"], (int)state["hue"], (int) state["sat"]);

                lightCollection.AddLight(new Light(Http, (string) key,(String) light["name"], lightState));

            }

            return lightCollection;
        }
    }
}