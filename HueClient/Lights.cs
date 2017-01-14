using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HueClient
{
    class Lights : IEnumerable
    {
        private List<Light> Items;

        public Lights(Light light)
        {
            Items.Add(light);
        }

        public Lights(List<Light> lights)
        {
            foreach (Light light in lights)
            {
                Items.Add(light);
            }
        }

        public IEnumerator GetEnumerator()
        {
            return Items.GetEnumerator();
        }
    }
}
