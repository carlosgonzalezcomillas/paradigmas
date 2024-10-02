using System;

namespace Practica_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cab 1
            Cab cab1 = new Cab("0001 AAA");
            Console.WriteLine(cab1);

            // Cab2
            Cab cab2 = new Cab("0002 BBB");
            Console.WriteLine(cab2);

            // Police car 1
            Police policeCar1 = new Police("0001 CNP");
            Console.WriteLine(policeCar1);

            // Police car 2
            Police policeCar2 = new Police("0002 CNP");
            Console.WriteLine(policeCar2);

            // Police 1 starts patrolling
            policeCar1.StartWork();

            // Police 1 sees cab 1 and shoots the radar
            policeCar1.UseRadar(cab1); 

            // Cab 2 picks up passengers
            cab2.StartWork(); 

            // Police 2 sees cab 2 and tries to shoot the radar
            policeCar2.UseRadar(cab2); 

            // Police car 2 starts patrolling
            policeCar2.StartWork();

            // Police 2 sees cab 2 and shoots the radar again
            policeCar2.UseRadar(cab2); 

            // Cab 2 finishes the ride
            cab2.FinishWork();

            // Police car 2 stops patrolling
            policeCar2.FinishWork();

            // Cab 1 picks up passengers
            cab1.StartWork();

            // Cab 1 tries to pick up new passengers
            cab1.StartWork(); 

            // Police 1 sees cab 1 and shoots the radar
            policeCar1.UseRadar(cab1); 

            // Cab 1 leaves the passengers
            cab1.FinishWork(); 

            // Police car 1 stops patrolling
            policeCar1.FinishWork();

            // Showing the radar reports
            policeCar1.ReportRadarData();
            policeCar2.ReportRadarData();
        }
    }
}
