using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject1
{
    class Name
    {
        String FirstName,LastName;
        public Name()
            : this("No First Name","No last name")
            {
            }
        public Name(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

        public void FullName()
        {
            Console.WriteLine("Full Name: {0} {1}",FirstName,LastName);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Name object1 = new Name();
            object1.FullName();
             
            Name object2= new Name("Shubhangi","Tomar");
            object2.FullName();
            Console.ReadKey();

        }
    }
}
