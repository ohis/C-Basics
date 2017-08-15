using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The area is " + Rectangle.CalculateArea(5, 4));

            Square sq;
            sq = new Square(4, 4);
            Console.WriteLine(sq.OutputArea());
            Console.ReadLine();
        }

        public static class Rectangle
        {
            public static int CalculateArea(int width, int height)
            {
                return width * height;
            }
        }

        public class Square
        {
            private int width, height;

            public Square(int width, int height)
            {
                this.width = width;
                this.height = height;
            }

            public int OutputArea()
            {
               
                    Console.WriteLine("Area output: " + Square.CalcArea(this.width, this.height));
                    return Square.CalcArea(this.width, this.height);
               
            }

            public static int CalcArea(int width, int height)
            {
                return width * height;
            }
        }
    }
}
