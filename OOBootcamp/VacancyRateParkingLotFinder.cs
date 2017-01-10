using System.Linq;

namespace OOBootcamp
{
    internal class VacancyRateParkingLotFinder : ParkingLotFinder
    {
        protected override ParkingLot FindParkingLotCore(ParkingLot[] lots)
        {
            return lots.OrderByDescending(lot => lot.VacancyRate).FirstOrDefault(lot => lot.VacancyRate != 0);
        }
    }
}