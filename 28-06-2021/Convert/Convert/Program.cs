using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                Id = 101,
                Name = "Shubhangi",
                Salary = 9090
            };
            Customer customer2 = new Customer()
            {
                Id = 102,
                Name = "Rahul",
                Salary = 9090
            };
            Customer customer3 = new Customer()
            {
                Id = 103,
                Name = "Kunal",
                Salary = 9090
            };

            Customer[] CustomerArray = new Customer[3];
            CustomerArray[0] = customer1;
            CustomerArray[1] = customer2;
            CustomerArray[2] = customer3;

            List<Customer> CustomerList = CustomerArray.ToList();

            Console.WriteLine("---------------List To Array---------------");
            foreach (Customer c in CustomerList)
            {
                Console.WriteLine("ID= {0} Name= {1}  Salary= {2}", c.Id, c.Name, c.Salary);
            }

            Console.WriteLine("---------------Array To List---------------");

            
            foreach (Customer c in CustomerList.ToArray())
            {
                Console.WriteLine("ID= {0} Name= {1}  Salary= {2}", c.Id, c.Name, c.Salary);
            }

            Console.ReadKey();

        }
    }
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
       }
}
