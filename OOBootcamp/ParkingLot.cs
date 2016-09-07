namespace OOBootcamp
{
    public class ParkingLot
    {
        private Car car;

        public string Park(Car car)
        {
            this.car = car;
            return "1";
        }

        public Car Pick(string ticket)
        {
            return car;
        }
    }
}