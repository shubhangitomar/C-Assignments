using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetterSetter1
{
    class MyClass
    {
        private int x;
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.X = 10;
            int xVal = obj.X;
            Console.WriteLine(xVal);//Displays 10 
            Console.ReadKey();
        }
    }
}
