using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter withdraw amount");
            double withdraw = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter total amount");
            double total = int.Parse(Console.ReadLine());

            if (withdraw % 5 == 0 && withdraw < total)
            {
                double Remaining = total - withdraw - 0.5;
                Console.WriteLine("Remaining balance is : {0}", Remaining);
            }
            else
            {
                Console.WriteLine("Remaining balance is : {0}", total);
            }
            Console.ReadKey();
        }
    }
}
