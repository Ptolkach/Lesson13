using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Building B = new Building("Moscow, Red Square, 1", 725, 730, 20);
            Console.WriteLine(B.Print());

            MultiBuilding MB = new MultiBuilding("SPB, Oblastnaya,1", 990, 16, 75, 25);
            Console.WriteLine(MB.Print());

            Console.ReadKey();

        }
    }
}
