namespace OOBootcamp
{
    public class ParkingBoy
    {
        protected readonly ParkingLot[] parkingLots;

        public ParkingBoy(params ParkingLot[] parkingLots)
        {
            this.parkingLots = parkingLots;
        }

        public virtual int Park(Car car)
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
            throw new AllParkingLotsFullException();
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
            return parkingLots[0].Pick(ticket);
        }
    }
}