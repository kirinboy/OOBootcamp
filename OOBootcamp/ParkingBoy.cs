namespace OOBootcamp
{
    public class ParkingBoy
    {
        public static ParkingBoy Default(params ParkingLot[] parkingLots)
        {
            return new ParkingBoy(new DefaultParkingLotFinder(), parkingLots);
        }

        public static ParkingBoy Smart(params ParkingLot[] parkingLots)
        {
            return new ParkingBoy(new VacancyCountParkingLotFinder(), parkingLots);
        }

        public static ParkingBoy Super(params ParkingLot[] parkingLots)
        {
            return new ParkingBoy(new VacancyRateParkingLotFinder(), parkingLots);
        }

        private readonly ParkingLot[] parkingLots;

        private readonly ParkingLotFinder parkingLotFinder;

        public ParkingBoy(ParkingLotFinder parkingLotFinder, params ParkingLot[] parkingLots)
        {
            this.parkingLots = parkingLots;
            this.parkingLotFinder = parkingLotFinder;
        }

        public int Park(Car car)
        {
            return parkingLotFinder.FindParkingLot(parkingLots).Park(car);
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