
using System.Collections.Generic;

namespace Library
{
    public class Driver : Person
    {

        private int capacity;

        public List<Passenger> passengers;


        public int Capacity {get; set;}
        public Driver(string name, string surname, string id, string imagePath, int capacity)
        : base (name,surname, id, imagePath)
        {
            this.Capacity = capacity;
        }


        public void AddPassenger(Passenger newPassenger)
        {
            if (this.Capacity > passengers.Count)
            {
                passengers.Add(newPassenger);
            }
        }

        public void RemovePassenger(Passenger passenger, int rating)
        {
            passengers.Remove(passenger);
            RatePassenger(passenger, rating);
        }
        public void RatePassenger(Passenger passenger, int rating)
        {
            passenger.AddRating(rating);
        }
    }
}
