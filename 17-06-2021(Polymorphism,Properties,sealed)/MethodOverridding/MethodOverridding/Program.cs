using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridding
{
    class Program
    {
        public class Base
        {
            public virtual void Show()
            {
                Console.WriteLine("This is Base Class.");
            }
        }
        public class Derived : Base
        {
            public override sealed void Show()
            {
                Console.WriteLine("This is Derived Class.");
            }
        }
        static void Main(string[] args)
        {

            Derived objBaseReference = new Derived();
            objBaseReference.Show();
            Console.ReadLine();
            Console.ReadKey();

        }
    }
}
