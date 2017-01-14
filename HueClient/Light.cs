using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HueClient
{
    class Light
    {
        private String Name;
        private LightState State;

        public Light(String name, LightState state)
        {
            Name = name;
            State = state;
        }
    }
}
