using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Boat boat1 = new InheritanceExamples.Boat(2, 500, "White and Yellow", 70.0d, .78d);
            boat1.Move();
            boat1.Move();
            Console.WriteLine("Boat " + boat1.GetDistanceTraveled());


            Automobile car1 = new Automobile(4, 4, 20, 5, 500, "Robust Red", 260);
            car1.Move();
            car1.Color = "Glittering Galant Gold";
            Console.WriteLine("Automobile " + car1.GetDistanceTraveled());


            AirCraft plane1 = new AirCraft(100, 100000, "Purple", 600);
            Console.WriteLine("Aircraft " + plane1.GetDistanceTraveled());

        }
    }
}
