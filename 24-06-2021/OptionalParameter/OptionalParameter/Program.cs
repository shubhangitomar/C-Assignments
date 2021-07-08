using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OptionalParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            AddNumbers(10,20,30,40,50);
            Console.ReadKey();
        }
        public static void AddNumbers(int FirstNumber, int SeconNumber, params object[] restofnumber)
        {
            int result = FirstNumber + SeconNumber;
            if (restofnumber != null)
            {
                foreach (int i in restofnumber)
                { result += i; }
            }
            Console.WriteLine("Sum ="+result);
        }
        
    }
}
