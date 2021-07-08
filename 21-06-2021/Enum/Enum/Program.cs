using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer[] customers = new Customer[3];

            customers[0] = new Customer { Name="Shubhangi", Gender=Gender.Female };
            customers[1] = new Customer { Name ="Rahul", Gender = Gender.Male };
            customers[2] = new Customer { Name = "XYZ", Gender = Gender.Unkonwn };
            foreach (Customer customer in customers)
            {           
                Console.WriteLine("{0}  {1}" ,customer.Name,customer.Gender);
            }
            Console.ReadKey();

        }
    }

    public enum Gender
    {
        Unkonwn,
        Male,
        Female
    }
    class Customer
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
    }
}
