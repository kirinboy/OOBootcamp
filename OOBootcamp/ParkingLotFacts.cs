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
            parkingLot.Park(new Car());

            Assert.Throws<ParkingLotFullException>(
                () =>
                {
                    parkingLot.Park(new Car());
                });
        }

        [Fact]
        public void should_be_able_to_park_car_when_a_parking_lot_is_no_longer_full()
        {
            var parkingLot = new ParkingLot(1);
            var ticket = parkingLot.Park(new Car());
            parkingLot.Pick(ticket);

            var anotherCar = new Car();
            var anotherTicket = parkingLot.Park(anotherCar);

            Assert.Same(anotherCar, parkingLot.Pick(anotherTicket));
        }

        [Fact]
        public void should_fail_to_pick_the_same_car_when_a_car_is_no_longer_in_a_parking_lot()
        {
            var parkingLot = new ParkingLot(1);
            var ticket = parkingLot.Park(new Car());
            parkingLot.Pick(ticket);

            Assert.Throws<NoCarException>(
                () =>
                {
                    parkingLot.Pick(ticket);
                });
        }

        [Fact]
        public void should_fail_to_pick_a_car_when_the_car_is_not_in_a_parking_lot()
        {
            var parkingLot = new ParkingLot(1);
            var ticketOfACarNotInParkingLot = string.Empty;

            Assert.Throws<NoCarException>(
                () =>
                {
                    parkingLot.Pick(ticketOfACarNotInParkingLot);
                });
        }
    }
}




