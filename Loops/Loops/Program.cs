using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //while loop

            int count = 0;

            while(count < 10)
            {
                Console.WriteLine(count);
                count++;

            }

            //for loop
            string name = "Markus";

            for(int i = 0; i < name.Length; i++)
            {
                Console.WriteLine("The  index is:" + i);

            }
            //foreach loop
            ArrayList list = new ArrayList();
            list.Add("mARK anTHONY");
            list.Add("Mike Scofield");
            list.Add("sOMEOne");

            foreach(string names in list)
            {
                Console.WriteLine(names);
            }
            Console.ReadLine();
        }
    }
}
