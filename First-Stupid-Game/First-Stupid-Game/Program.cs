using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Stupid_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Creatures man = new Creatures("Peter");
            Console.WriteLine("{0}'s healt is {1}", man.creatureName, man.healthPoints);

            Nature obj = new Nature();
            Console.WriteLine("{0}", obj.natureName);

            Things thing = new Things();
            Console.WriteLine("{0}", thing.thingName);

            //
            Console.ReadLine();
        }
    }
}
