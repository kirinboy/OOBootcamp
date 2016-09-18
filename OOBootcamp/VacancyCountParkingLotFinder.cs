using System.Linq;

namespace OOBootcamp
{
    public class VacancyCountParkingLotFinder : ParkingLotFinder
    {
        protected override ParkingLot FindParkingLotCore(ParkingLot[] lots)
        {
            return lots.OrderByDescending(lot => lot.VacancyCount).FirstOrDefault(lot => lot.VacancyCount != 0);
        }
    }
}