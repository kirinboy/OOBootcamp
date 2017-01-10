using System.Linq;

namespace OOBootcamp
{
    internal class DefaultParkingLotFinder : ParkingLotFinder
    {
        protected override ParkingLot FindParkingLotCore(ParkingLot[] lots)
        {
            return lots.FirstOrDefault(lot => lot.VacancyCount != 0);
        }
    }
}