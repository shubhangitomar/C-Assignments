using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertRange
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                Id = 101,
                Name = "Shubhangi",
                Salary = 9090,
                Type = "Retail"
            };
            Customer customer2 = new Customer()
            {
                Id = 102,
                Name = "Rahul",
                Salary = 9090,
                Type = "Corporate"
            };
            Customer customer3 = new Customer()
            {
                Id = 103,
                Name = "Sandeep",
                Salary = 9090,
                Type = "Corporate"
            };
            Customer customer4 = new Customer()
            {
                Id = 104,
                Name = "Kunal",
                Salary = 9090,
                Type = "Retail"
            };


            List<Customer> ListCustomer = new List<Customer>();
            ListCustomer.Add(customer1);
            ListCustomer.Add(customer4);


            List<Customer> CorporateCustomer = new List<Customer>();
            CorporateCustomer.Add(customer2);
            CorporateCustomer.Add(customer3);


            //InsertRange(position of index where we want to insert elements,List)
            ListCustomer.InsertRange(2, CorporateCustomer);

            foreach (Customer c in ListCustomer)
            {
                Console.WriteLine("Id={0}  Name= {1} Salary= {2}  Type= {3}", c.Id, c.Name, c.Salary, c.Type);
            }

            Console.ReadKey();

        }
    }
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Type { get; set; }

    }
}
