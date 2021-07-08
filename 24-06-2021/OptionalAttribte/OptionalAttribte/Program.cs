using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace OptionalAttribte
{
    class Program
    {
        static void Main(string[] args)
        {
            AddNumbers(20,10);
            Console.ReadKey();
        }
        public static void AddNumbers(int FirstNumber, int SeconNumber,[OptionalAttribute] int[] restofnumber)
        {
            int result = FirstNumber + SeconNumber;
            if (restofnumber != null)
            {
                foreach (int i in restofnumber)
                { result += i; }
            }
            Console.WriteLine("Sum =" + result);
        }
    }
}
