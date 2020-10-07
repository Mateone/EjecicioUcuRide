
using System.Collections.Generic;

namespace Library
{
    public class Driver : Person
    {

        private int capacity;

        public List<Passanger> passengers;


        public int Capacity {get; set;}
        public Driver(string name, string surname, string id, int capacity)
        : base (name,surname, id)
        {     
            this.Capacity = capacity;
        }


        public void AddPassenger(Passanger newPassenger)
        {
            if (this.Capacity > passengers.Count)
            {
                passengers.Add(newPassenger);
            }
        }

        public void RemovePassenger(Passanger passenger)
        {
            passengers.Remove(passenger);
            // De alguna manera, pedir Rating       
        }
    }

}
