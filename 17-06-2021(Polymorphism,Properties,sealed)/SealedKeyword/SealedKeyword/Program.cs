using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedKeyword
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
            Base obj= new Derived();
            obj.Show();// Output ---> This is Derived Class.    
            Console.ReadKey();
        }
    }
}
