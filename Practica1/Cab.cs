using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
{
    internal class Cab : Vehicle
    {
        private bool _carryingPassenger;
        
        public Cab(string plate) : base("Cab", plate, 45)
        {
            _carryingPassenger = false;
        }

        public override void StartWork()
        {
            if (!_carryingPassenger)
            {
                Speed = 100;
                _carryingPassenger = true;
                Console.WriteLine($"Taxi with plate {Plate}: starts a ride");
            }
            else
            {
                Console.WriteLine($"Taxi with plate {Plate}: is already carrying passengers.");
            }
        }

        public override void FinishWork()
        {
            if (_carryingPassenger)
            {
                Speed = 45;
                _carryingPassenger = false;
                Console.WriteLine($"Taxi with plate {Plate}: finishes a ride");
            }
            else
            {
                Console.WriteLine($"Taxi with plate {Plate}: is not carrying passengers.");
            }
        }
    }
}
