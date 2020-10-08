using System;
using CognitiveCoreUCU;

namespace Library
{
    public class Passenger : Person
    {
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
                    if (cogFace.FaceFound)
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
        public Passenger(string name, string surname, string id, string imagePath)
        :base (name, surname, id, imagePath)
        {
        }
        public void RateDriver(Driver driver, int rating)
        {
            driver.AddRating(rating);
        }
    }
}