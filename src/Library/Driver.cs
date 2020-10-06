
using System.Collections.Generic;

namespace Library
{
    public class Driver : Person
    {
        public Driver(string name, string surname, string id)
        : base (name,surname, id)
        {     
        }

        public override int Rating()
        {
            return 1;
        }

    }
}