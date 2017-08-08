using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[2];//the 2 represents the size of the array
            names[0] = "John Doe";
            names[1] = "Jane Doe";

            foreach (string s in names)
                Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
