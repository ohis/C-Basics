using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_tut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            for (int i = 1; i < args.Length; i++)
            {
                Console.WriteLine("Arg{0} : {1}", i, args[i]);
            }

             Console.ReadLine();

        }
    }
}
