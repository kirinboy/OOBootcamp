namespace OOBootcamp
{
    public abstract class ParkingLotFinder
    {
        public ParkingLot FindParkingLot(ParkingLot[] lots)
        {
            var theFirstAvailableParkingLot = FindParkingLotCore(lots);
            if (theFirstAvailableParkingLot == null)
            {
                throw new AllParkingLotsFullException();
            }
            return theFirstAvailableParkingLot;
        }

        protected abstract ParkingLot FindParkingLotCore(ParkingLot[] lots);
    }
}