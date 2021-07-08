using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overflowing
{
    class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                byte number = 255;
                number += 1;
                Console.WriteLine(number);
            }
             Console.ReadKey();
        }
    }
}
