namespace Library
{
    public class Passenger : Person
    {
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