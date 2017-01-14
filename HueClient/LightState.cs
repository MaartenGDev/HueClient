using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HueClient
{
    class LightState
    {
        private int Brightness;
        private int Hue;
        private int Saturation;
        private Light Light;
        private HttpClient Http;
        private HueUser User;

        public LightState(int brightness, int hue, int saturation)
        {
            Brightness = brightness;
            Hue = hue;
            Saturation = saturation;
        }

        public LightState SetBrightness(int brightness)
        {
            Brightness = brightness;

            return this;
        }

        public LightState SetHue(int hue)
        {
            Hue = hue;
            String apiToken = User.Token;
            String apiHost = User.Host;

            String state = Http.Get($"http://{apiHost}/api/{apiToken}/lights/{Light.Id}/state");

            Console.WriteLine(state);
            return this;
        }

        public LightState SetSaturation(int hue)
        {
            Hue = hue;
            String apiToken = User.Token;
            String apiHost = User.Host;

            String state = Http.Get($"http://{apiHost}/api/{apiToken}/lights/{Light.Id}/state");
            return this;
        }
        public void SetHttpClient(HttpClient http)
        {
            Http = http;
        }

        public void SetLight(Light light)
        {
            Light = light;
        }

        public void SetUser(HueUser user)
        {
            User = user;
        }
    }
}
