using System.Linq;

namespace OOBootcamp
{
    public class SmartParkingBoy : ParkingBoy
    {
        public SmartParkingBoy(params ParkingLot[] parkingLots) : base(parkingLots)
        {
        }

        public override int Park(Car car)
        {
            var parkingLotWithMostVacancyCount = parkingLots.OrderByDescending(lot => lot.VacancyCount).First();
            if (parkingLotWithMostVacancyCount.VacancyCount == 0)
            {
                throw new AllParkingLotsFullException();
            }
            return parkingLotWithMostVacancyCount.Park(car);
        }
    }
}