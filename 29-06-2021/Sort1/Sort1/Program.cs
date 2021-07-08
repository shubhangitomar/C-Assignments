using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1,2,3,4,8,6,7};
            numbers.Sort();
            foreach (int number in numbers)
            { 
                Console.WriteLine(number);
            }
            Console.ReadKey();
        }
    }
}
