using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HueClient
{
    class Program
    {
        static void Main(string[] args)
        {
            HueUser user = new HueUser("i3xooZyH9up22k-zOUbVyWYv9RWTB7B3pfEIWPuM", "192.168.2.21");
            HttpClient http = new HttpClient(user);

            Hue hue = new Hue(http, user);

            Lights lights = hue.AllLights();

            foreach (Light light in lights)
            {
                light.SetHue(25500);
            }
           
            Console.ReadLine();
        }
    }
}
