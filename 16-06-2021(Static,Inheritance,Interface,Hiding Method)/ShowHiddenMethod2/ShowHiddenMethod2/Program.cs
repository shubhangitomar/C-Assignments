using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowHiddenMethod2
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
           
            Console.WriteLine("Name: Rakesh, Age: 40 \nName: Somya, " +
                                   "Age: 39 \nName: Rohan, Age: 20 ");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            MyMember obj = new MyMember();
            // Invoking the hidden method
            // By type casting
            ((MyFamily)obj).member();
            Console.ReadKey();
        }
    }
}
