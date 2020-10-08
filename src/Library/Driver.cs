
using System.Collections.Generic;
using System;


namespace Library
{
    public class Driver : Person
    {
        private string bio;
        public string Bio
        {
            get
            {
                return this.bio;
            }

            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    this.bio = value;
                }
            }
        }

        private int capacity;
        public int Capacity
        {
            get
            {
                return this.capacity;
            }

            set
            {
                this.Capacity = value;
            }
        }
        public List<Passenger> passengers;
        public Driver(string name, string surname, string id, string imagePath, int capacity, string bio)
        : base (name,surname, id, imagePath)
        {
            this.Capacity = capacity;
            this.Bio = bio;
        }


        public void AddPassenger(Passenger newPassenger)
        {
            if (this.Capacity > passengers.Count)
            {
                passengers.Add(newPassenger);
            }
        }

        public void RemovePassenger(Passenger passenger, int passengerRating, int driverRating)
        {
            passengers.Remove(passenger);
            RatePassenger(passenger, passengerRating);
            passenger.RateDriver(this, driverRating);
        }
        public void RatePassenger(Passenger passenger, int rating)
        {
            passenger.AddRating(rating);
        }
    }
}
