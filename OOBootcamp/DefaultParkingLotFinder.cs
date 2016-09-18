using System.Linq;

namespace OOBootcamp
{
    public class DefaultParkingLotFinder
    {
        public ParkingLot FindParkingLot(ParkingLot[] lots)
        {
            var theFirstAvailableParkingLot = lots.FirstOrDefault(lot => lot.VacancyCount != 0);
            if (theFirstAvailableParkingLot == null)
            {
                throw new AllParkingLotsFullException();
            }
            return theFirstAvailableParkingLot;
        }
    }
}