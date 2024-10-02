namespace Practice1
{
    internal class Program
    {
        static void Main()
        {
            City city = new City();
            Console.WriteLine("City created.");

            PoliceStation policeStation = new PoliceStation();
            Console.WriteLine("Police station created.");

            Taxi taxi1 = new Taxi("0001 AAA");
            Taxi taxi2 = new Taxi("0002 BBB");
            city.RegisterTaxiLicense(taxi1);
            city.RegisterTaxiLicense(taxi2);

            PoliceCar policeCar1 = new PoliceCar("0001 CNP");
            PoliceCar policeCar2 = new PoliceCar("0002 CNP");
            PoliceCar policeCar3 = new PoliceCar("0003 CNP"); 

            policeStation.RegisterPolice(policeCar1);
            policeStation.RegisterPolice(policeCar2);
            policeStation.RegisterPolice(policeCar3);

            SpeedRadar radar1 = new SpeedRadar();
            SpeedRadar radar2 = new SpeedRadar();

            policeCar1.AssignRadar(radar1); 
            policeCar2.AssignRadar(radar2); 

            policeCar3.StartPatrolling();
            policeCar3.UseRadar(taxi1); 

            policeCar1.StartPatrolling();
            taxi1.StartRide();
            policeCar1.UseRadar(taxi1); 
            policeStation.TriggerAlert(taxi1.GetPlate()); 

            policeCar2.StartPatrolling();
            policeStation.TriggerAlert(taxi1.GetPlate());

            city.RemoveTaxiLicense(taxi1.GetPlate());

            // Mostrar el estado final
            Console.WriteLine("\n--- Final state ---");
            city.ShowRegisteredTaxis();
            policeStation.ShowRegisteredPolice();
            policeCar1.PrintRadarHistory();
            policeCar2.PrintRadarHistory();
        }
    }
}
