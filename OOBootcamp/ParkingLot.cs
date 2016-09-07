namespace OOBootcamp
{
    public class ParkingLot
    {
        private Car car;
        private int capacity;

        public ParkingLot(int capacity)
        {
            this.capacity = capacity;
        }

        public string Park(Car car)
        {
            if (capacity == 0)
            {
                throw new ParkingLotFullException();
            }
            this.car = car;
            capacity--;
            return "1";
        }

        public Car Pick(string ticket)
        {
            capacity++;
            return car;
        }
    }
}