
using System.Collections.Generic;
using System;
using CognitiveCoreUCU;


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

        public override string ImagePath
        { 
            get
            {
                return this.imagePath;
            }
            set
            {
                if(!String.IsNullOrWhiteSpace(value))
                {
                    CognitiveFace cogFace = new CognitiveFace("620e818a46524ceb92628cde08068242",false);
                    cogFace.Recognize(value);
                    if (cogFace.FaceFound && cogFace.SmileFound)
                    {
                        this.imagePath = value;
                    }
                    else
                    {
                        this.imagePath = "../Program/blank_face.jpeg";
                    }
                }
                else
                {
                    this.imagePath = "../Program/blank_face.jpeg";
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
                this.capacity = value;
            }
        }
        public List<Passenger> passengers;
        public Driver(string name, string surname, string id, string imagePath, int capacity, string bio)
        : base (name,surname, id, imagePath)
        {
            this.Capacity = capacity;
            this.Bio = bio;
        }

        public Driver(string name, string surname, string id, string imagePath, string bio)
        : base (name,surname, id, imagePath)
        {
            this.Bio = bio;
            this.Capacity = 1;
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
