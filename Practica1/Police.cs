using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
{
    internal class Police : Vehicle
    {
        public bool IsPatrolling { get; private set; }
        private Radar? radar;

        public Police(string plate) : base("Police", plate, 0)
        {
            IsPatrolling = false;
            radar = null; 
        }

        public override void StartWork()
        {
            if (!IsPatrolling)
            {
                IsPatrolling = true;
                radar = new Radar(); 
                Console.WriteLine($"Police car with plate {Plate}: started patrolling.");
            }
            else
            {
                Console.WriteLine($"Police car with plate {Plate}: is already patrolling.");
            }
        }

        public override void FinishWork()
        {
            if (IsPatrolling)
            {
                IsPatrolling = false;
                Console.WriteLine($"Police car with plate {Plate}: stopped patrolling.");
            }
            else
            {
                Console.WriteLine($"Police car with plate {Plate}: was not patrolling.");
            }
        }

        public void UseRadar(Cab cab) 
        {
            if (IsPatrolling && radar != null)
            {
                Console.WriteLine($"Police car with plate {Plate}: Triggered radar: {radar.MeasureSpeed(cab)}");
            }
            else
            {
                Console.WriteLine($"Police car with plate {Plate}: has no active radar.");
            }
        }

        public void ReportRadarData()
        {
            if (radar != null)
            {
                Console.WriteLine($"Police car with plate {Plate}: Report radar history:");
                radar.ShowSpeedHistory(); 
            }
            else
            {
                Console.WriteLine("There is no radar history because police car with plate {Plate} did not active the radar o was not patrolling.");
            }
        }
    }
}
