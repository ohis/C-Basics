using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car;

            Cost cost;
            car = new Car("Red");
            Console.WriteLine(car.Describe());

            car = new Car("Green");
            Console.WriteLine(car.Describe());

            cost = new Cost(5000);
            Console.WriteLine("This car costs "+ "$"+cost.DisplayPrice());

            Console.ReadLine();
        }
    }

    class Car
    {
        private string color;

        public Car(string color)
        {
            this.color = color;
        }

        public string Describe()
        {
            return "This car is " + Color;
        }

        public string Color
        {
            get { return color.ToUpper(); }
            set {
                if (value == "Red")
                    color = value;
                else

                    Console.WriteLine("This car can only be red!"); }

        }
    }

    class Cost
    {
        private int price;

        public Cost(int Price)
        {
            this.price = Price;
        }

        public int DisplayPrice()
        {
            return  price;
        }

       
    }
}
