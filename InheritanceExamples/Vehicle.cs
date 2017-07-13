using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExamples
{
    class Vehicle
    {
        //fields
        protected int seats;
        protected int carryingCapacity;
        protected string color;
        protected double movementSpeed;//we don't want our movement speed to change so we wont create a prop for it
        protected double distanceTraveled;

        private float gearRaio;
        private float engineSize;

        //propterties
        public int Seats { get; }
        public int CarryingCapacity { get; }
        public string Color { get; set; }
        public double MyProperty { get; set; }

        //constructors //you always need a default constructor, and especially so with inheritance
        //what is a constructor signature
        public Vehicle()
        {

        }
        public Vehicle(int seats, int carryingCapacity, string color, double movementSpeed)
        {
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;
        }
        public virtual void Move ()
        {
            distanceTraveled += movementSpeed;
        }

        public virtual string GetDistanceTraveled()
        {
            return "Distance Traveled: " + distanceTraveled + "\n";
        }
        //this.whatever is referring to the particular field created above
    }
}
