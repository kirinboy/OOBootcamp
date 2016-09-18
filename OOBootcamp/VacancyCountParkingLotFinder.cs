using System.Linq;

namespace OOBootcamp
{
    public class VacancyCountParkingLotFinder
    {
        public ParkingLot FindParkingLot(ParkingLot[] lots)
        {
            var parkingLotWithMostVacancyCount = lots.OrderByDescending(lot => lot.VacancyCount).FirstOrDefault(lot => lot.VacancyCount != 0);
            if (parkingLotWithMostVacancyCount == null)
            {
                throw new AllParkingLotsFullException();
            }
            return parkingLotWithMostVacancyCount;
        }
    }
}