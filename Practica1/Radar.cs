using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
{
    internal class Radar : IMessageWriter
    {
        private List<int> speedHistory = new List<int>();
        private const int MaxLegalSpeed = 50;

        public string MeasureSpeed(Cab vehicle)
        {
            speedHistory.Add(vehicle.Speed);
            string message = $"Result: Vehicle with plate {vehicle.Plate} at {vehicle.Speed} km/h.";

            if (vehicle.Speed > MaxLegalSpeed)
            {
                return $"{message} {WriteMessage("Catched above legal speed")}";
            }
            else
            {
                return $"{message} {WriteMessage("Driving legally")}";
            }
        }

        public void ShowSpeedHistory()
        {
            foreach (var speed in speedHistory)
            {
                Console.WriteLine($"{speed} km/h");
            }
        }

        public virtual string WriteMessage(string customMessage)
        {
            return  $"{customMessage}";
        }

    }
}
