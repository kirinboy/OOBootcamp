using System.Linq;

namespace OOBootcamp
{
    public class SmartParkingBoy
    {
        private readonly ParkingLot[] parkingLots;

        public SmartParkingBoy(params ParkingLot[] parkingLots)
        {
            this.parkingLots = parkingLots;
        }

        public int Park(Car car)
        {
            var parkingLotWithMostVacancyCount = parkingLots.OrderByDescending(lot => lot.VacancyCount).FirstOrDefault(lot => lot.VacancyCount != 0);
            if (parkingLotWithMostVacancyCount == null)
            {
                throw new AllParkingLotsFullException();
            }
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