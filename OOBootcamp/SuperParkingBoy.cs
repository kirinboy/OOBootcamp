namespace OOBootcamp
{
    public class SuperParkingBoy
    {
        public static ParkingBoy Super(params ParkingLot[] parkingLots)
        {
            return new ParkingBoy(new VacancyRateParkingLotFinder(), parkingLots);
        }

        private readonly ParkingLot[] parkingLots;
        private readonly ParkingLotFinder parkingLotFinder;

        private SuperParkingBoy(ParkingLotFinder parkingLotFinder, params ParkingLot[] parkingLots)
        {
            this.parkingLots = parkingLots;
            this.parkingLotFinder = parkingLotFinder;
        }

        public int Park(Car car)
        {
            var parkingLotWithHighestVacancyRate = parkingLotFinder.FindParkingLot(parkingLots);
            return parkingLotWithHighestVacancyRate.Park(car);
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