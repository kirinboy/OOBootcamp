using System.Linq;

namespace OOBootcamp
{
    public class ParkingBoy
    {
        private readonly ParkingLot[] parkingLots;

        public ParkingBoy(params ParkingLot[] parkingLots)
        {
            this.parkingLots = parkingLots;
        }

        public virtual int Park(Car car)
        {
            var theFirstAvailableParkingLot = parkingLots.FirstOrDefault(lot => lot.VacancyCount != 0);
            if (theFirstAvailableParkingLot == null)
            {
                throw new AllParkingLotsFullException();
            }
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