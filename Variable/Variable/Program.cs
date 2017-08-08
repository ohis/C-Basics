using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "John";
            string lastName = "Doe";
            int num1;
            int num2;
            double x;
            double y;
            double z;

            Console.WriteLine("Name: " + firstName + " " + lastName);
           // Console.WriteLine("Please enter a new first name:");
            //firstName = Console.ReadLine();

            //Console.WriteLine("New name: " + firstName + " " + lastName);

            Console.WriteLine("Please enter a number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Thank you. One more:");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Adding the two numbers: " + (num1 + num2));
            x = 16.5;
            y = 5;
            z = x / y;

            Console.WriteLine("The division of the numbers are :" + z);

            Console.ReadLine();
        }
    }
}
