using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
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

            foreach ( Customer c in customer)
            Console.WriteLine("ID= {0} Name= {1}  Salary= {2}",c.Id,c.Name,c.Salary);

            if (customer.Contains(customer3))
            {
                Console.WriteLine("EXIST");
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
