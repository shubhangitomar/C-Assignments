using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            AddNumbers(10,20,new int[] { 40,50});
            Console.ReadKey();
        }
        public static void AddNumbers(int FirstNumber, int SeconNumber)
        {
            AddNumbers(FirstNumber, SeconNumber, null);
        }
        public static void AddNumbers(int FirstNumber, int SeconNumber, int[] restofnumber)
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
