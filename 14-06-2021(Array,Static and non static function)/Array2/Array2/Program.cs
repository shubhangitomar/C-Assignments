using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of array");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];

            Console.WriteLine("Enter value of array");
            for (int i = 0; i < length; i++)
            {
                Console.Write("element - {0} : ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("\nElements in array are: ");
            for (int i = 0; i < length; i++)
            {
                Console.Write("{0}  ", array[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("Maximum number from array is {0} " ,array.Max());
            Console.WriteLine("Minimum number from array is {0} ", array.Min());
            Console.WriteLine("Sum number from array is {0} ", array.Sum());
            Console.WriteLine("Average number from array is {0} ", array.Average());
            Console.ReadKey();
        }
    }
}
