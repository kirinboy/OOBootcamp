namespace OOBootcamp
{
    public class SmartParkingBoy
    {
        public static ParkingBoy Smart(params ParkingLot[] parkingLots)
        {
            return new ParkingBoy(new VacancyCountParkingLotFinder(), parkingLots);
        }

        private readonly ParkingLot[] parkingLots;
        private readonly ParkingLotFinder parkingLotFinder;

        private SmartParkingBoy(ParkingLotFinder parkingLotFinder, params ParkingLot[] parkingLots)
        {
            this.parkingLots = parkingLots;
            this.parkingLotFinder = parkingLotFinder;
        }

        public int Park(Car car)
        {
            var parkingLotWithMostVacancyCount = parkingLotFinder.FindParkingLot(parkingLots);
            return parkingLotWithMostVacancyCount.Park(car);
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