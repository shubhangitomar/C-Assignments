using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Equall = Add.AreEquall<int>(10,10);
            if (Equall)
            {
                Console.WriteLine("Equall");
            }
            else
            {
                Console.WriteLine("Not Equall");
            }
            Console.ReadKey();
        }
    }

    public class Add
    {
        public static Boolean AreEquall<T>(T value1,T Value2)
        {
            return value1.Equals(Value2);
        }
    }
}
