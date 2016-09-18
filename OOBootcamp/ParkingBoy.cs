namespace OOBootcamp
{
    public class ParkingBoy
    {
        private readonly ParkingLot[] parkingLots;

        public ParkingBoy(params ParkingLot[] parkingLots)
        {
            this.parkingLots = parkingLots;
        }

        public int Park(Car car)
        {
            var theFirstAvailableParkingLot = new DefaultParkingLotFinder().FindParkingLot(parkingLots);
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