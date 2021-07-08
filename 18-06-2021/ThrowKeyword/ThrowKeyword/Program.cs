using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrowKeyword
{
    public class Student
    {
        public string StudentName { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student std = null;

            try
            {
                PrintStudentName(std);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
        private static void PrintStudentName(Student std)
        {
            if (std == null)
                throw new NullReferenceException("Student object is null.");
            //Use Throw keyword if we want to raise exception manually

            Console.WriteLine(std.StudentName);
        }
    }
}
