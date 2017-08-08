using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Please enter a number between 0 and 10");
            num = int.Parse(Console.ReadLine());

            if (num > 10)
                Console.WriteLine("Number should be less than 10");
            else
                if (num < 0)
                Console.WriteLine("Hey number should be greter than or equal to zero");

                else
                    Console.WriteLine("Good job");

            //Using the OR statement
            if ((num > 10) || (num < 0))
                Console.WriteLine("Hey! The number should be 0 or more and less than 10");
            else
                Console.WriteLine("Good job bro");
            Console.ReadLine();

        }
    }
}
