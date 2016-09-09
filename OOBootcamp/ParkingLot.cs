namespace OOBootcamp
{
    public class ParkingLot
    {
        private readonly Car[] parkedCars;
        private readonly int capacity;
        private int remainder;

        public ParkingLot(int capacity)
        {
            this.capacity = capacity;
            remainder = capacity;
            parkedCars = new Car[capacity];
        }

        public int Park(Car car)
        {
            if (remainder == 0)
            {
                throw new ParkingLotFullException();
            }

            var theFirstEmptyIndex = 0;
            for (var index = 0; index < capacity; index++)
            {
                if (parkedCars[index] == null)
                {
                    theFirstEmptyIndex = index;
                    break;
                }
            }
            parkedCars[theFirstEmptyIndex] = car;
            remainder--;

            return theFirstEmptyIndex;
        }

        public Car Pick(int ticket)
        {
            var pickedCar = parkedCars[ticket];
            if (pickedCar == null)
            {
                throw new NoCarException();
            }

            remainder++;
            parkedCars[ticket] = null;

            return pickedCar;
        }
    }
}