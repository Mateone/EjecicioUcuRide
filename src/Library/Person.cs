using System;
using Library;
using System.Collections.Generic;

namespace Library
{
    public abstract class Person
    {
        private string imagePath;
        public string ImagePath
        {
            get
            {
                return this.imagePath;
            }
            set
            {
                if(!String.IsNullOrWhiteSpace(value))
                {
                    this.imagePath = value;
                }
            }
        }
        private List<int> rating = new List<int>();
        public int Rating
        {
            get
            {
                int totalRating = 0;
                foreach (int ratings in rating)
                {
                    totalRating += ratings;
                }
                return (totalRating / (rating.Count));
            }
        }
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

        public Person(string name, string surname, string id, string imagePath)
        {
            this.Name = name;
            this.Surname = surname;
            this.ID = id;
            this.ImagePath = imagePath;
        }
        public void AddRating(int value)
        {
            if (value <= 5 && value >= 1)
            {
                rating.Add(value);
            }
            else
            {
                Console.WriteLine("Ingrese un valor entre 1 y 5");
            }
        }
    }
}