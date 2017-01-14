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
            HueUser user = new HueUser("secure", "192.168.1.1");
            HttpClient http = new HttpClient();

            Hue hue = new Hue(http, user);

            Lights lights = hue.AllLights();

            Console.ReadLine();
        }
    }
}
