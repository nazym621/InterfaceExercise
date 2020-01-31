using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
     public class Car
    {
        public Car()
        {
            Wheels = 4;
            Doors = 4;
            Seats = 4;
        }
        public int Wheels { get; set; }
        public int Doors { get; set; }
        public int Seats { get; set; }
        public bool IsParked { get; set; }
        public bool IsInReverse { get; set; }
        public int TrunkSize { get; set; }
    }
}
