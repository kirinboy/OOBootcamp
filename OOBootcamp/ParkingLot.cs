namespace OOBootcamp
{
    public class ParkingLot
    {
        private Car theFirstCar;
        private Car theSecendCar;
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

            if (theFirstCar == null)
            {
                capacity--;
                theFirstCar = car;
                return "1";
            }

            capacity--;
            theSecendCar = car;
            return "2";
        }

        public Car Pick(string ticket)
        {
            if (ticket == "1")
            {
                var pickedCar = theFirstCar;
                if (pickedCar == null)
                {
                    throw new NoCarException();
                }
                theFirstCar = null;
                capacity++;
                return pickedCar;
            }
            if (ticket == "2")
            {
                capacity++;
                return theSecendCar;
            }
            throw new NoCarException();
        }
    }
}