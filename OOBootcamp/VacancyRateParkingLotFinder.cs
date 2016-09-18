using System.Linq;

namespace OOBootcamp
{
    public class VacancyRateParkingLotFinder
    {
        public ParkingLot FindParkingLot(ParkingLot[] lots)
        {
            var parkingLotWithHighestVacancyRate = lots.OrderByDescending(lot => lot.VacancyRate).FirstOrDefault(lot => lot.VacancyRate != 0);
            if (parkingLotWithHighestVacancyRate == null)
            {
                throw new AllParkingLotsFullException();
            }
            return parkingLotWithHighestVacancyRate;
        }
    }
}