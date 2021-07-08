using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class Program
    {
        public class Demo
        {
            public void Add(string a1, string a2)
            {
                Console.WriteLine("Adding Two String :" + a1 + a2);
            }
            public void Add(int a1, int a2)
            {
                Console.WriteLine("Adding Two Integer :" + a1 + a2);
            }
        }
        static void Main(string[] args)
        {
            Demo obj = new Demo();  
            obj.Add("Shubhangi" , "Tomar");  
            obj.Add(5, 10);  
             Console.ReadKey();


        }
    }
}
