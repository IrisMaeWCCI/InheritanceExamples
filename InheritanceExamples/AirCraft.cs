using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExamples
{
    class AirCraft : Vehicle
    {
        //field
        private double altitude;
        //proptery
        public double Altitude { get; }
        //constructor
        public AirCraft()
        {

        }

        public AirCraft(int seats, int carryCapacity, string color, double movementSpeed)
        {
            this.seats = seats;
            this.carryingCapacity = carryingCapacity; //why is this messing up?
            this.color = color;
            this.movementSpeed = movementSpeed;

            altitude = 0.0d;
            //set the default altitude inside of the, not the default constructor
        }

        public override void Move()
        {
            altitude += 10000.0d;
            base.Move();
        }
        public override string GetDistanceTraveled()
        {
            return "Altitude " + altitude + "-" + base.GetDistanceTraveled();
        }
    }
}

