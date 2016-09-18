namespace OOBootcamp
{
    public class ParkingBoy
    {
        public static ParkingBoy Default(params ParkingLot[] parkingLots)
        {
            return new ParkingBoy(new DefaultParkingLotFinder(), parkingLots);
        }

        private readonly ParkingLot[] parkingLots;
        private readonly ParkingLotFinder parkingLotFinder;

        private ParkingBoy(ParkingLotFinder parkingLotFinder, params ParkingLot[] parkingLots)
        {
            this.parkingLots = parkingLots;
            this.parkingLotFinder = parkingLotFinder;
        }

        public int Park(Car car)
        {
            var theFirstAvailableParkingLot = parkingLotFinder.FindParkingLot(parkingLots);
            return theFirstAvailableParkingLot.Park(car);
        }

        public Car Pick(int ticket)
        {
            foreach (var parkingLot in parkingLots)
            {
                try
                {
                    return parkingLot.Pick(ticket);
                }
                catch (NoCarException e)
                {
                    continue;
                }
            }
            throw new NoCarException();
        }
    }
}