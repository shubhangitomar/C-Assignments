using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of test Case");
            int Case = int.Parse(Console.ReadLine());

            for (int i = 1; i <= Case; i++)
            {
                int min1, min2;
              
                Console.WriteLine("Enter number of elements");
                int Elements = int.Parse(Console.ReadLine());
                int[] arr = new int[Elements];
                for (int j = 0; j < Elements; j++)
                {
                    arr[j] = Convert.ToInt32(Console.ReadLine());
                }
                if (arr[0] < arr[1])
                {
                    min1 = arr[0];
                    min2 = arr[1];
                }
                else
                {
                    min1 = arr[1];
                    min2 = arr[0];
                }

                for (int k = 2; k < Elements; k++)
                {
                    if (arr[k] < min1)
                    {
                        min2 = min1;
                        min1 = arr[k];
                    }
                    else if (arr[k] < min2)
                    {
                        min2 = arr[k];
                    }
                }

                Console.WriteLine("The Sum of Smallest Number is :{0}", min1+min2);
            }
            Console.ReadKey();
        }
    }
}
