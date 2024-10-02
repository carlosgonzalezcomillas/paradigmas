using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class PoliceStation
    {
        private List<PoliceCar> policeCars;
        private string? lastAlert;

        public PoliceStation()
        {
            policeCars = new List<PoliceCar>();
            lastAlert = "";
        }

        public void RegisterPolice(PoliceCar policeCar)
        {
            policeCars.Add(policeCar);
            Console.WriteLine($"Police car {policeCar.GetPlate()}: has been registered");
        }

        public void TriggerAlert(string crimePlate)
        {
            lastAlert = crimePlate;
            Console.WriteLine($"Active alert for persecution of taxi: {crimePlate}");

            foreach (var policeCar in policeCars)
            {
                if (policeCar.IsPatrolling())
                {
                    if (!policeCar.IsPersecuting())
                    {
                        policeCar.StartPersecution(crimePlate);
                    }
                 
                }
            }
        }

        public void ShowRegisteredPolice()
        {
            Console.WriteLine("Registered police cars: ");
            foreach (var police in policeCars)
            {
                Console.WriteLine(police.ToString());
            }
        }

    }

}
