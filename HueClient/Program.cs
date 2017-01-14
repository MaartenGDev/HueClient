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
            HueUser user = new HueUser("token");
            HttpClient http = new HttpClient();

            Hue hue = new Hue(http, user);

            hue.AllLights();

            Console.ReadLine();
        }
    }
}
