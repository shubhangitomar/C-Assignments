using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Shubhangi",
                Salary = 9090
            };
            Customer customer2 = new Customer()
            {
                ID = 102,
                Name ="Rahull",
                Salary = 9090
            };
            Dictionary<int, Customer> CustomerDictionary = new Dictionary<int, Customer>();
            CustomerDictionary.Add(customer1.ID,customer1);
            CustomerDictionary.Add(customer2.ID, customer2);
            Console.WriteLine(CustomerDictionary[101].Name);


            foreach(Customer c1 in CustomerDictionary.Values)
            {
                Console.WriteLine("ID = {0}  Name = {1} Salary ={2}",c1.ID,c1.Name,c1.Salary);
            }

            Console.ReadKey();
        }
    }
    class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

    }
}
