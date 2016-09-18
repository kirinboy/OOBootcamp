namespace OOBootcamp
{
    public class SuperParkingBoy
    {
        private readonly ParkingLot[] parkingLots;

        public SuperParkingBoy(params ParkingLot[] parkingLots)
        {
            this.parkingLots = parkingLots;
        }

        public int Park(Car car)
        {
            var parkingLotWithHighestVacancyRate = new VacancyRateParkingLotFinder().FindParkingLot(parkingLots);
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