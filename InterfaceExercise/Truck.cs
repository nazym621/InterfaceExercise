using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck:IVehicle, ICompany
    {
        public Truck()
        {
            Wheels = 4;
            Doors = 2;
            Seats = 2;
        }


        public int Wheels { get; set; }
        public int Doors { get; set; }
        public int Seats { get; set; }
        public bool IsParked { get; set; }
        public bool IsInReverse { get; set; }
        public int BedSize { get; set; }


        public void Drive()
        {
            IsParked = false;
            Console.WriteLine($"This truck drives with...");
        }
        public void Park()
        {
            IsParked = true;
            Console.WriteLine($"The truck is parked.");
        }
        public void Reverse()
        {
            IsInReverse = false;
            Console.WriteLine($"The truck is now reversinng");
        }

        public void ShowLogo()
        {
            Console.WriteLine();
        }
    }
}
