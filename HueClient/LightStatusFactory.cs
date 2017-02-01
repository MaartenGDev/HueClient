using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HueClient
{
    class LightStatusFactory
    {
        
        public LightState Create(String key)
        {
            return GetStateForKey(key);
        }

        private LightState GetStateForKey(String key)
        {
            Dictionary<String, int> settings = new Dictionary<String, int>();

            if(key == "prod")
            {
               return new LightState { Brightness = 77, Saturation = 251, Hue = 251 };
            }else if (key == "movie")
            {
                return new LightState { Brightness = 100, Saturation = 100, Hue = 100 };
            }else if (key == "sleep")
            {
                return new LightState { Brightness = 50, Saturation = 6200, Hue = 251 };
            }

            return new LightState { Brightness = 100, Saturation = 100, Hue = 100 };
        }
    }
}
