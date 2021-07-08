using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder userstring = new StringBuilder("C#");
            userstring.Append(" Video");
            userstring.Append(" Tutorial");
            Console.WriteLine(userstring);
            Console.ReadKey();
        }
    }
}
