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
            int brightness = 100;
            int saturation = 100;
            int hue = 100;

            if (key == "prod")
            {
                brightness = 120;
                saturation = 120;
                hue = 8402;
            }else if (key == "movie")
            {
                brightness = 100;
                saturation = 100;
                hue = 100;
            }else if (key == "sleep")
            {
                brightness = 67;
                saturation = 251;
                hue = 6291;
            }

            Console.WriteLine("Setting light to " + key + " mode");
            return new LightState { Brightness = brightness, Saturation = saturation, Hue = hue };
        }
    }
}
