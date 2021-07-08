using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates1
{
    public delegate void MyDelegate(string msg); //declaring a delegate
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate del = new MyDelegate(ClassA.MethodA);
            del("Hello World");

            del = new MyDelegate(ClassB.MethodB);
            del("Hello World");

            Console.ReadKey();
        }
    }
    class ClassA
    {
       public static void MethodA(string message)
        {
            Console.WriteLine("Called ClassA.MethodA() with parameter: " + message);
        }
    }

    class ClassB
    {
       public static void MethodB(string message)
        {
            Console.WriteLine("Called ClassB.MethodB() with parameter: " + message);
        }
    }
}
