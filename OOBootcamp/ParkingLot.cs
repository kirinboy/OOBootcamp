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

            var theFirstEmptyIndex = GetTheFirstEmptyIndex();
            parkedCars[theFirstEmptyIndex] = car;
            remainder--;

            return car.GetHashCode();
        }

        private int GetTheFirstEmptyIndex()
        {
            for (var index = 0; index < capacity; index++)
            {
                if (parkedCars[index] == null)
                {
                    return index;
                }
            }
            return 0;
        }

        public Car Pick(int ticket)
        {
            Car pickedCar = null;
            int pickedIndex = 0;
            for (var index = 0; index < capacity; index++)
            {
                if (parkedCars[index] != null && parkedCars[index].GetHashCode() == ticket)
                {
                    pickedCar = parkedCars[index];
                    pickedIndex = index;
                }
            }
            if (pickedCar == null)
            {
                throw new NoCarException();
            }

            remainder++;
            parkedCars[pickedIndex] = null;

            return pickedCar;
        }
    }
}