using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{

    public interface A
    {
        void ReadFile();
    }
    public interface B
    {
        void WriteFile(string text);
    }

    public class C :A,B
    {
        public void ReadFile()
        {
            Console.WriteLine("Reading File");
        }

        public void WriteFile(string text)
        {
            Console.WriteLine("Writing to file :{0}",text);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            C object1 = new C();
            object1.ReadFile();
            object1.WriteFile("Shubhangi");
            Console.ReadKey();
        }
    }
}
