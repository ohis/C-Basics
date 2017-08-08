using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions
{
    class Program
    {   
        public int Add(int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            Program n = new Program();
            Console.WriteLine("The sum of the two numbers are" + " " + n.Add(5, 4));
            string name = "angel";
           Console.WriteLine("just wanted to print"+ " "+ Name(name));
            Console.ReadLine();
        }

        static string Name(string x)
        {
           
            Console.WriteLine("Printing DoStuff");
            return x;
        }
    }
}
