using System;
namespace labbonus17
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double price;

        public string Make {
            get {
                return this.make;
            }
            set {
                this.make = value;
            }
        }

        public Car(string make, string model, int year, double price)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;
        }
        public Car()
        {
            this.make = "default";
            this.model = "default";
            this.year = 0000;
            this.price = 0000;

        }
        public override string ToString()
        {
            string response = string.Format(" make {0}, \n model {1}, \n year {2}, \n price {3} \n" , make, model, year, price);
            return response;
        }



    }
}
