using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("eNTER A number");
            num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 90:
                    Console.WriteLine("That is an A");
                    break;
                case 80:
                    Console.WriteLine("That's a B");
                    break;
                case 70:
                    Console.WriteLine("That's a C");
                    break;
                default:
                    Console.WriteLine("you either failed or you have not inputed the right number");
                    break;
            }

            Console.ReadLine();
        }
    }
}
