using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterDefaults
{
    class Program
    {
        static void Main(string[] args)
        {
            AddNumbers(10,20,new int[] { 10,20});
            Console.ReadKey();
        }
        public static void AddNumbers(int FirstNumber, int SeconNumber, int[] restofnumber=null)
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
