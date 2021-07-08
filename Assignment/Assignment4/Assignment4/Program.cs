using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Total Number of TestCases");
            int Cases = int.Parse(Console.ReadLine());
            int[] Amount = new int[Cases];
            Console.WriteLine("Enter Amount");
            for(int i =0; i<Cases; i++)
            {
                 Amount[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < Cases; i++)
            {
                int temp;
                temp = Amount[i] / 100;
                Amount[i] = Amount[i] - (temp*100);
                int NumberOfNotes = temp;

                temp = Amount[i] / 50;
                Amount[i] = Amount[i] - (temp * 50);
                NumberOfNotes += temp;

                temp = Amount[i] / 10;
                Amount[i] = Amount[i] - (temp * 10);
                NumberOfNotes += temp;

                temp = Amount[i] / 5;
                Amount[i] = Amount[i] - (temp * 5);
                NumberOfNotes += temp;

                temp = Amount[i] / 2;
                Amount[i] = Amount[i] - (temp * 2);
                NumberOfNotes += temp;

                temp = Amount[i] / 1;
                Amount[i] = Amount[i] - (temp * 1);
                NumberOfNotes += temp;

                Console.WriteLine("Total Number of notes: {0}",NumberOfNotes);

            }
            Console.ReadKey();
            
        }
    }
}
