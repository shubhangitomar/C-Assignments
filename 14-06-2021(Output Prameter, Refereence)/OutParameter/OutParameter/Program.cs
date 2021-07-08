using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            int Total = 0;
            int Product = 0;
            Calculation(2, 3, out Total, out Product);
            Console.WriteLine("Sum:{0}  product:{1}",Total,Product);
            Console.ReadKey();
        }
        public static void Calculation(int i,int j,out int Sum,out int Product)
        {
            Sum = i + j;
            Product = i * j;
        }
    }
}
