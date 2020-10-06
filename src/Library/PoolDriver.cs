
using System.Collections.Generic;

namespace Library
{
    public class PoolDriver: Driver
    {   
        public PoolDriver(string name, string surname, string id)
        : base (name,surname, id)
        {     
        }


        private List<Passanger> Passengers;
    }



}