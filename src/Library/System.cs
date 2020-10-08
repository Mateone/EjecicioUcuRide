using System.Collections.Generic;
using TwitterUCU;

namespace Library
{
    public class RideSystem 
    {
        private TwitterImage twitterImage= new TwitterImage("CkovShLMNVCY0STsZlcRUFu99", "6rc35cHCyqFQSy4vIIjKiCYu31qqkBBkSS5BRlqeYCt5r7zO5B", "1396065818-MeBf8ybIXA3FpmldORfBMdmrVJLVgijAXJv3B18", "gNytQjJgLvurJekVU0wmBBkrR1Th40sJmTO8JDhiyUkuy");
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
                twitterImage.PublishToTwitter($"Welcome to Uber, I mean UCURide. Our new driver {newDriver.Name}.\n{newDriver.Bio}.", newDriver.Picture);
            }
        }

        public void AddPassenger(Passenger newPassenger)
        {
            if (!passengers.Contains(newPassenger))
            {
                passengers.Add(newPassenger);
                twitterImage.PublishToTwitter($"Welcome to Uber, I mean UCURide. Our new passenger {newPassenger.Name}.", newPassenger.Picture);
            }
        }
    }

}
