using System;
using System.Collections;
using Library;

namespace PII_Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Passenger pasajero1 = new Passenger("Mateo", "Negrin", "8.765.432-1", "bill2.jpg");
            Passenger pasajero2 = new Passenger("Alvaro", "Machado", "8.765.432-1", "main.jpg");
            Passenger pasajero3 = new Passenger("Gonzalo", "Martinez", "8.765.432-1", "nicolas-cage.jpg");
            Passenger pasajero4 = new Passenger("Mauricio", "Pacheco", "8.765.432-1", "nicolas-cage.jpg");
            Driver conductor1 = new Driver("Baby", "Driver", "8.765.432-1", "nicolas-cage.jpg", "I like trains.");
            Driver conductorPool1 = new Driver("Baby", "Driver", "8.765.432-1", "nicolas-cage.jpg", 3, "I don't like trains.");
            RideSystem rideShare = new RideSystem();
            
            rideShare.AddDriver(conductor1);
            rideShare.AddDriver(conductorPool1);
            rideShare.AddPassenger(pasajero1);
            rideShare.AddPassenger(pasajero2);
            rideShare.AddPassenger(pasajero3);
            rideShare.AddPassenger(pasajero4);

        }
    }
}
