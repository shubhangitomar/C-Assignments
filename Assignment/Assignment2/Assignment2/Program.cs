using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number of test Cases");
            int Cases= int.Parse(Console.ReadLine());
            for (int i = 1; i <= Cases; i++)
            {
                Console.WriteLine("Enter Number of elements in Alice and Berta Collection");
                int A = int.Parse(Console.ReadLine());
                int B = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Elements of Alice Collection");
           
                List<int> AliceList = new List<int>(A);
                for(int j=1;j<=A;j++)
                {
                    int AliceNumber = int.Parse(Console.ReadLine());
                    AliceList.Add(AliceNumber);
                }

                Console.WriteLine("Enter Elements of Berta Collection");
                List<int> BertaList = new List<int>(B);
                for (int k = 1; k<= B; k++)
                {
                    int BertaNumber = int.Parse(Console.ReadLine());
                    BertaList.Add(BertaNumber);
                }

                var CommonList = AliceList.Intersect(BertaList);
                int Value=CommonList.Count();
                Console.WriteLine("minimal amount of numbers Alice needs to throw away from her collection : {0}",Value);
            }

            Console.ReadKey();
        }
    }
}
