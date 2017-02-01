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
        public HttpClient Http;
        public LightState State;

        public Light(HttpClient http, String id, String name)
        {
            Http = http;
            Id = id;
            Name = name;
        }

        public void SetHue(int hue)
        {
            Dictionary<String, int> lightState = new Dictionary<String, int>();

            lightState.Add("hue", hue);

            ChangeLightState(lightState);
        }

        public LightState getState()
        {
            String baseUri = BuildAuthQuery();

            String response = Http.Get($"{baseUri}/lights/{Id}");

            JObject light = JObject.Parse(response);

            light = (JObject)light["state"];

            LightState lightState = GenerateLightState((int)light["bri"], (int)light["hue"], (int)light["sat"]);

            return lightState;
        }

        private LightState GenerateLightState(int Brightness, int Hue, int Saturation)
        {
            LightState state = new LightState();

            state.Brightness = Brightness;
            state.Hue = Hue;
            state.Saturation =  Saturation;

            return state;
        }

        public void SetBri(int brightness)
        {
            Dictionary<String, int> lightState = new Dictionary<String, int>();

            lightState.Add("bri", brightness);

            ChangeLightState(lightState);
        }

        public void SetState(LightState state)
        {
            SetBri(state.Brightness);
            SetHue(state.Hue);
            SetSat(state.Saturation);

            State = state;
        }

        private void SetSat(int saturation)
        {
            Dictionary<String, int> lightState = new Dictionary<String, int>();

            lightState.Add("sat", saturation);

            ChangeLightState(lightState);
        }

        private void ChangeLightState(Dictionary<String, int> lightState)
        {

            String jsonState = JsonConvert.SerializeObject(lightState);
            String baseUri = BuildAuthQuery();

            String state = Http.Put($"{baseUri}/lights/{Id}/state", jsonState);
        }

        private String BuildAuthQuery()
        {
            HueUser user = Http.getUser();

            String apiToken = user.Token;

            String apiHost = user.Host;

            return ($"http://{apiHost}/api/{apiToken}");
        }
    }
}
