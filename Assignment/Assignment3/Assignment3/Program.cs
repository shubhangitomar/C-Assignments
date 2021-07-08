using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Total Number of input");
            int Number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= Number; i++)
            {
                int Fact = 1;
                Console.WriteLine("Enter elements");
                int Value = int.Parse(Console.ReadLine());
                for (int j = Value; j >= 1; j--)
                {
                    Fact *= j;
                }
                Console.WriteLine(Fact);
                
            }
            Console.ReadKey();
        }
    }
}
