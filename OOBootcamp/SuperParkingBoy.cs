using System.Linq;

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
            var parkingLotWithHighestVacancyRate = parkingLots.OrderByDescending(lot => lot.VacancyRate).FirstOrDefault();
            if (parkingLotWithHighestVacancyRate != null && parkingLotWithHighestVacancyRate.VacancyRate == 0)
            {
                throw new AllParkingLotsFullException();
            }
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