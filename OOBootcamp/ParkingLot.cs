using System;

namespace OOBootcamp
{
    public class ParkingLot
    {
        private Car theFirstCar;
        private Car theSecendCar;
        private Car[] parkedCars;
        private int capacity;
        private int remainder;

        public ParkingLot(int capacity)
        {
            this.capacity = capacity;
            remainder = capacity;
            parkedCars = new Car[capacity];
        }

        public string Park(Car car)
        {
            if (remainder == 0)
            {
                throw new ParkingLotFullException();
            }

            var currentIndex = capacity - remainder;
            parkedCars[currentIndex] = car;
            remainder--;

            return currentIndex.ToString();
        }

        public Car Pick(string ticket)
        {
            int ticketNumber;
            if (!int.TryParse(ticket, out ticketNumber))
            {
                throw new NoCarException();
            }

            var pickedCar = parkedCars[ticketNumber];
            if (pickedCar == null)
            {
                throw new NoCarException();
            }
            remainder++;
            parkedCars[ticketNumber] = null;

            return pickedCar;
        }
    }
}