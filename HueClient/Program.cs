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
            Console.WriteLine("welcome");
            Light room = new Light("A1");

            Console.WriteLine(room.Name);

            Console.ReadLine();
        }
    }
}
