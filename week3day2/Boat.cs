using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3day2
{
    class Boat
    {
        //fields. values we can use in program. describes characteristics. actual information about that class.
        public int numberOfPassengers;

        private string name;
        private double engineSize; 

        //properties. this is so we can expose this private field to other parts of our program.
        public string Name
        {
            get { return name; }   //could be ambiguity. to use 'this.' confines it to the class.
            set { name = value; }
        }

        //constructor
        public Boat()
        {

        }

        public Boat(int numberOfPassengers, string name, double engineSize)
        {
            this.numberOfPassengers = numberOfPassengers;
            this.name = name;
            this.engineSize = engineSize;
        }

        //methods
        public void Move()
        {
            //code to make boat move
            Console.WriteLine(name + " moves forward.");



        }

        private double CalculateMPG() //private so we don't expose the details to it. So how do we get it? Look down.
        {
            //code to calculate MPG
            double MPG = engineSize * .7d;

            return MPG;
        }

        public void BoatInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Passengers: " + numberOfPassengers);
            Console.WriteLine("Engine Size: " + engineSize);
            Console.WriteLine("MPG: " + CalculateMPG()); //you can call a method in a method. 
            Console.WriteLine();
        }




    }
}
