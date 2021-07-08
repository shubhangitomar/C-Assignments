using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHidingNew
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

        // Reimplement the method of the base class
        // Using new keyword
        // It hides the method of the base class
        public new void member()
        {
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
