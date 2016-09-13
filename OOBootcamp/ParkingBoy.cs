using System;
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
            foreach (var parkingLot in parkingLots)
            {
                try
                {
                    return parkingLot.Park(car);
                }
                catch (ParkingLotFullException e)
                {
                    continue;
                }
            }
            return parkingLots[0].Park(car);
        }

        public Car Pick(int ticket)
        {
            return parkingLots[0].Pick(ticket);
        }
    }
}