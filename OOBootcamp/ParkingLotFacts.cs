using System;
using Xunit;

namespace OOBootcamp
{
    public class ParkingLotFacts
    {
        [Fact]
        public void should_be_able_to_pick_the_same_car_when_park_a_car_to_a_parking_lot()
        {
            var parkingLot = new ParkingLot();
            var car = new Car();

            var ticket = parkingLot.Park(car);

            Assert.Same(car, parkingLot.Pick(ticket));
        }
    }
}




