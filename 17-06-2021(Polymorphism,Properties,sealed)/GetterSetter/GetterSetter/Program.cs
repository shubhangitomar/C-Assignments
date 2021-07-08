using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetterSetter
{
    class MyClass
    {
        private int x;
        public void SetX(int i)
        {
            x = i;
        }
        public int GetX()
        {
            return x;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.SetX(10);
            int xVal = obj.GetX();
            Console.WriteLine(xVal);
            Console.ReadKey();
        }
    }
}
