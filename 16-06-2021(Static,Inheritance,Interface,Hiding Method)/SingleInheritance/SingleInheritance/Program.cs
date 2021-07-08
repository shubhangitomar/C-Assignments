using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleInheritance
{
    class Shape
    {
        public double Width;
        public double Height;
        public void ShowDim()
        {
            Console.WriteLine("Width and height are " +
            Width + " and " + Height);
        }
    }


    class Triangle : Shape
    {  
        public double Area()
        {
            return Width * Height / 2;
        }
       
    }

    class Program
    {
        static void Main(string[] args)
        {
            Triangle t1= new Triangle();
            t1.Width = 10;
            t1.Height = 10;
            t1.ShowDim();
            Console.WriteLine("Area is " + t1.Area());


            Shape sp = new Shape();
            sp.Width = 10;
            sp.Height = 10;
            sp.ShowDim();
            //Error
            //Console.WriteLine("Area is " + sp.Area());
            Console.ReadKey();

        }
    }
}
