using System;
using System.Collections.Generic;

namespace labbonus17
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Car> carlist = new List<Car>();

            Console.WriteLine("Welcome to the Grand Circus Motors admin console!");


            /Console.WriteLine("How many cars are you entering?");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("What is the make of the vehicle?");
                string make = Console.ReadLine();
                Console.WriteLine("What is the model of the vehicle?");
                string model = Console.ReadLine();
                Console.WriteLine("What is the year of the vehicle?");
                int year = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the price of the vehicle?");
                double price = double.Parse(Console.ReadLine()); 



                carlist.Add(new Car ()); 
             

            }
            foreach (Car Car in carlist)
            {
                Console.WriteLine(Car.ToString());
            }



        }

    }


}
