using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HueClient
{
    class LightState
    {
        private int Brigtness;
        private int Hue;
        private int Saturation;

        public LightState(int brightness, int hue, int saturation)
        {
            Brigtness = brightness;
            Hue = hue;
            Saturation = saturation;
        }
    }
}
