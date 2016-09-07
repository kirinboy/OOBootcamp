using Xunit;

namespace OOBootcamp
{
    public class ParkingLotFacts
    {
        [Fact]
        public void should_be_able_to_pick_the_same_car_when_park_a_car_to_a_parking_lot()
        {
            var parkingLot = new ParkingLot(1);
            var car = new Car();

            var ticket = parkingLot.Park(car);

            Assert.Same(car, parkingLot.Pick(ticket));
        }

        [Fact]
        public void should_fail_to_park_car_when_a_parking_lot_is_full()
        {
            var parkingLot = new ParkingLot(1);
            var car1 = new Car();
            parkingLot.Park(car1);

            var car2 = new Car();

            Assert.Throws<ParkingLotFullException>(
                () =>
                {
                    parkingLot.Park(car2);
                });
        }
    }
}




