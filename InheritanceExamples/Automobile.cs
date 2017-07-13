using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExamples
{
    class Automobile : Vehicle 
    {
        //fields
        private int numberOfWheels;
        private float wheelSize;
        private int numberOfDoors;
        //properties
        public int NumberOfWheels { get; }
        public int NumberOfDoors { get; }
        public float WheelSize { get; }
        //constructors
        public Automobile()
        {

        }
        public Automobile(int numberOfWheels, int numberOfDoors, float WheelSize, int seats, int carryingCapacity, string color, double movementSpeed)
        {
            this.numberOfDoors = numberOfDoors;
            this.numberOfWheels = numberOfWheels;
            this.wheelSize = wheelSize;//why is this messing up?
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;
        }
    }
}
