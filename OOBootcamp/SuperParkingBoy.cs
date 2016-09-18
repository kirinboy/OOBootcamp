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
            var parkingLotWithHighestVacancyRate = FindParkingLot();
            return parkingLotWithHighestVacancyRate.Park(car);
        }

        private ParkingLot FindParkingLot()
        {
            var parkingLotWithHighestVacancyRate = parkingLots.OrderByDescending(lot => lot.VacancyRate).FirstOrDefault(lot => lot.VacancyRate != 0);
            if (parkingLotWithHighestVacancyRate == null)
            {
                throw new AllParkingLotsFullException();
            }
            return parkingLotWithHighestVacancyRate;
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