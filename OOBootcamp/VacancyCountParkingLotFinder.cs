using System.Linq;

namespace OOBootcamp
{
    internal class VacancyCountParkingLotFinder : ParkingLotFinder
    {
        protected override ParkingLot FindParkingLotCore(ParkingLot[] lots)
        {
            return lots.OrderByDescending(lot => lot.VacancyCount).FirstOrDefault(lot => lot.VacancyCount != 0);
        }
    }
}