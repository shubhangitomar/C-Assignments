using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
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
                Name = "Sandeep",
                Salary = 9090
            };
            Customer customer4 = new Customer()
            {
                Id = 104,
                Name = "Kunal",
                Salary = 9090
            };

            Queue<Customer> CustomerQueue = new Queue<Customer>();
            CustomerQueue.Enqueue(customer1);
            CustomerQueue.Enqueue(customer2);
            CustomerQueue.Enqueue(customer3);
            CustomerQueue.Enqueue(customer4);
            

            foreach (Customer c in CustomerQueue)
            {
                Console.WriteLine("Id={0}  Name= {1} Salary= {2}  ", c.Id, c.Name, c.Salary);
            }

            Console.WriteLine("-----------------DEQUEUE---------------------");
            CustomerQueue.Dequeue();
            foreach (Customer c in CustomerQueue)
            {
                Console.WriteLine("Id={0}  Name= {1} Salary= {2}  ", c.Id, c.Name, c.Salary);
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
