using System;
using Library;

namespace Library
{
    public class Person
    {
        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if(!String.IsNullOrWhiteSpace(value))
                {
                    this.name = value;
                }
            }
        }
        private string surname;
        public string Surname
        {
            get
            {
                return this.surname;
            }
            set
            {
                if(!String.IsNullOrWhiteSpace(value))
                {
                    this.surname = value;
                }
            }
        }
        private string id;
        public string ID
        {
            get
            {
                return this.id;
            }

            set
            {
                if (IdUtils.IdIsValid(value))
                {
                    this.id = value;
                }
            }
        }

        public Person(string name, string surname, string id)
        {
            this.Name = name;
            this.Surname = surname;
            this.ID = id;
        }
    }
}