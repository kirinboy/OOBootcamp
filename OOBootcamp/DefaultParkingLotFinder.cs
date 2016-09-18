using System.Linq;

namespace OOBootcamp
{
    public class DefaultParkingLotFinder : ParkingLotFinder
    {
        protected override ParkingLot FindParkingLotCore(ParkingLot[] lots)
        {
            return lots.FirstOrDefault(lot => lot.VacancyCount != 0);
        }
    }
}