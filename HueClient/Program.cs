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
            Boolean hasQuestion = true;

            Hue hue = new Hue(http, user);

            Lights lights = hue.AllLights();

            while (hasQuestion)
            {

                String command = Console.ReadLine();

                if(command == "stop")
                {
                    hasQuestion = false;
                    return;
                }

                LightStatusFactory factory = new LightStatusFactory();

                foreach (Light light in lights)
                {
                    LightState state = light.getState();

                    Console.WriteLine("Bri: " + state.Brightness);
                    Console.WriteLine("Hue: " + state.Hue);
                    Console.WriteLine("Sat: " + state.Saturation);
                    Console.WriteLine("---");

                    factory.Create("prod");

                    light.SetState(factory.Create(command));

                }
            }
   

        }
    }
}
