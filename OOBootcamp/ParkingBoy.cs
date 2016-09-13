using System.Collections.Generic;

namespace OOBootcamp
{
    public class ParkingBoy
    {
        private readonly ParkingLot[] parkingLots;

        public ParkingBoy(ParkingLot parkingLot)
        {
            parkingLots = new[] {parkingLot};
        }

        public ParkingBoy(ParkingLot[] parkingLots)
        {
            this.parkingLots = parkingLots;
        }

        public int Park(Car car)
        {
            return parkingLots[0].Park(car);
        }

        public Car Pick(int ticket)
        {
            return parkingLots[0].Pick(ticket);
        }
    }
}