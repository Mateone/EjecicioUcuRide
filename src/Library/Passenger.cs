namespace Library
{
    public class Passenger : Person
    {
        public Passenger(string name, string surname, string id)
        :base (name, surname, id)
        {
        }
        public void RateDriver(Driver driver, int rating)
        {
            driver.AddRating(rating);
        }
    }
}