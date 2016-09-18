using System.Linq;

namespace OOBootcamp
{
    public class VacancyRateParkingLotFinder : ParkingLotFinder
    {
        protected override ParkingLot FindParkingLotCore(ParkingLot[] lots)
        {
            return lots.OrderByDescending(lot => lot.VacancyRate).FirstOrDefault(lot => lot.VacancyRate != 0);
        }
    }
}