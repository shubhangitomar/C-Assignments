using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //implicit type conversion
            byte number = 20;
            int i = number;
            Console.WriteLine(i);

            //explicit
            float fnumber = 1.0f;
            int i2 =(int)fnumber;
            Console.WriteLine(i2);


            //conversion between non-compatible type
            string s = "1";
            int i3 = int.Parse(s);
            Console.WriteLine(i3);

            int i4 = Convert.ToInt16(s);
            Console.WriteLine(i4);

            Console.ReadKey();
           
        }
    }
}
