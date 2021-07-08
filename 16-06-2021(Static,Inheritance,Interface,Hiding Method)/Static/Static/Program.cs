using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class Program
    {
        static int val1 = 20;
        int val2 = 20;
        static void Main(string[] args)
        {
            Console.WriteLine(val1); //in Static we need not to create object to print value

            Program x = new Program();//Create an object to access
            int newval = x.val2;
            Console.WriteLine(newval);
            Console.ReadKey();
        }
    }
}
