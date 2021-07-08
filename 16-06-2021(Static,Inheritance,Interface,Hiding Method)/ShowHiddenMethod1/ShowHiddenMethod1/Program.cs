using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowHiddenMethod1
{
    public class MyFamily
    {

        public void member()
        {
            Console.WriteLine("Total number of family members: 3");
        }
    }

    // Derived Class
    public class MyMember : MyFamily
    {
        
        public new void member()
        {
            // Calling the hidden method of the
            // base class in a derived class
            // Using base keyword
            base.member();
            Console.WriteLine("Name: Rakesh, Age: 40 \nName: Somya, " +
                                   "Age: 39 \nName: Rohan, Age: 20 ");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            MyMember obj = new MyMember();
            obj.member();
            Console.ReadKey();
        }
    }
}
