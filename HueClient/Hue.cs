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
        private List<Light> Lights;

        public Hue(HttpClient http, HueUser user)
        {
            Http = http;
            User = user;
        }

        public List<Light> AllLights()
        {
            return Lights;
        }
    }
}