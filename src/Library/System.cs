using System.Collections.Generic;

namespace Library
{
    public class RideSystem
    {
        private List<Passenger> passengers;
        public List<Passenger> Passengers{get;}
        private List<Driver> drivers;
        public List<Driver> Drivers{get;}

        public RideSystem()
        {
            passengers = new List<Passenger>();
            drivers = new List<Driver>();
        }

        public void AddDriver(Driver newDriver)
        {
            if (!drivers.Contains(newDriver))
            {
                drivers.Add(newDriver);
            }
        }

        public void AddPassenger(Passenger newPassenger)
        {
            if (!passengers.Contains(newPassenger))
            {
                passengers.Add(newPassenger);
            }
        }

        private void SendMessage(Person person)
        {
            
        }
    }

}
