using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number Test Cases");
            int Case = int.Parse(Console.ReadLine());
            for (int i = 1; i <= Case; i++)
            {
                string[] inputs = Console.ReadLine().Split(null);

                int input1 =Convert.ToInt32(inputs[0]);
                int input2 =Convert.ToInt32(inputs[1]);
                if(input1<input2)
                {
                    for (int j = input1+1; j < input2; j++)
                    {
                        if (j % 2 != 0)
                        {
                            Console.WriteLine(j);
                        }
                    }
                }
                else
                    Console.WriteLine("Please Enter elements in assending order");
               
            }
            Console.ReadKey();
        }
    }
}
