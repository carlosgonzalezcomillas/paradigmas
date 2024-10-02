using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class Skate : Vehicle
    {
        private const string typeOfVehicle = "Skate";

        public Skate() : base(typeOfVehicle)
        {
        }

        public void StartRide()
        {
            SetSpeed(15);
            Console.WriteLine(WriteMessage("started a ride."));
        }

        public void StopRide()
        {
            SetSpeed(0);
            Console.WriteLine(WriteMessage("stopped the ride."));
        }

    }

}
