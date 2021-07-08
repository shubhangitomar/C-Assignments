using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultidimentionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr2d = new int[3, 2]{
                                {1, 2},
                                {3, 4},
                                {5, 6}
                            };

            Console.WriteLine(arr2d[0, 0]); //1
            Console.WriteLine(arr2d[0, 1]); //2
            Console.WriteLine(arr2d[1, 0]); //3
            Console.WriteLine(arr2d[1, 1]); //4
            Console.WriteLine(arr2d[2, 0]); //5
            Console.WriteLine(arr2d[2, 1]); //6
            Console.ReadKey();
        }
    }
}
