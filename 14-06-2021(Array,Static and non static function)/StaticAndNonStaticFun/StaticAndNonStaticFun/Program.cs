using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndNonStaticFun
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
           Console.WriteLine( p.Sum2(1,2));

            Console.WriteLine(Program.Sum1(2,3));
            Console.ReadKey();
        }

        public static int Sum1(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Sum2(int num1, int num2)
        {
            return num1 + num2;
        }

        
    }
}
