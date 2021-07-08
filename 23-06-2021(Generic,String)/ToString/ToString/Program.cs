using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToString
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer obj = new Customer();
            obj.FirstName = "Shubhangi";
            obj.LastName = "Tomar";

            Console.WriteLine(Convert.ToString(obj));
            Console.ReadKey();
        }
    }
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return this.FirstName + " "+ this.LastName;
        }
    }
}
