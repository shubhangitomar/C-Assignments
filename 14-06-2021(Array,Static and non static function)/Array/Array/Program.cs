using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[3];
            Numbers[0] = 1;
            Numbers[1] = 2;
            Numbers[2] = 3;
            Console.WriteLine(Numbers[0]);

            int[] Number1 = { 1, 2, 3, 4 };
            Console.WriteLine(Number1[0]);

            Console.ReadKey();

        }
    }
}
