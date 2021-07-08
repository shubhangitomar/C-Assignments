using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 1st Number: ");
           int  n = int.Parse(Console.ReadLine());
            Console.Write("Enter 2nd Number: ");
           int  m = int.Parse(Console.ReadLine());

            int sum = n + m;
            Console.WriteLine("Sum :" +sum);

            int multiply = n * m;
            Console.WriteLine("Multiplication:" +multiply);

            int precedence=n + m* sum;
            Console.WriteLine("precedence:" + precedence);


            double radius = 2.50;
            double area = Math.PI * radius * radius;
            Console.WriteLine(area);

            Console.ReadKey();
        }
    }
}
