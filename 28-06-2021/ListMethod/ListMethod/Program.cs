using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListMethod
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

            List<Customer> customer = new List<Customer>(2);
            customer.Add(customer1);
            customer.Add(customer2);
            customer.Add(customer3);

            if (customer.Contains(customer3))
            {
                Console.WriteLine("EXIST");
            }
            else
            {
                Console.WriteLine("Not Exist");
            }
            if (customer.Exists(cust => cust.Name.StartsWith("S")))
            {
                Console.WriteLine("EXIST");
            }
            else
            {
                Console.WriteLine("Not Exist");
            }

            Console.WriteLine("--------------Find------------------------");
            Customer c = customer.Find(cust => cust.Salary > 5000);
            Console.WriteLine("ID= {0} Name= {1}  Salary= {2}", c.Id, c.Name, c.Salary);

            Console.WriteLine("--------------FindLast------------------------");
            Customer c1 = customer.FindLast (cust => cust.Salary > 5000);
            Console.WriteLine("ID= {0} Name= {1}  Salary= {2}", c1.Id, c1.Name, c1.Salary);

            Console.WriteLine("--------------FindAll------------------------");
            List<Customer> customers = customer.FindAll(cust => cust.Salary > 5000);
            foreach(Customer c2 in customers)
            Console.WriteLine("ID= {0} Name= {1}  Salary= {2}", c2.Id, c2.Name, c2.Salary);


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
