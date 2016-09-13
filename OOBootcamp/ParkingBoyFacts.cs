﻿using System.Collections.Generic;
using Xunit;

namespace OOBootcamp
{
    public class ParkingBoyFacts
    {
        [Fact]
        public void should_be_able_to_pick_the_same_car_from_the_parking_lot_when_parking_boy_park_the_car()
        {
            var parkingLot = new ParkingLot(1);
            var parkingBoy = new ParkingBoy(parkingLot);
            var car = new Car();

            var ticket = parkingBoy.Park(car);

            Assert.Same(car, parkingLot.Pick(ticket));
        }

        [Fact]
        public void should_be_able_to_pick_the_same_car_by_parking_boy_when_parking_boy_park_the_car()
        {
            var parkingLot = new ParkingLot(1);
            var parkingBoy = new ParkingBoy(parkingLot);
            var car = new Car();

            var ticket = parkingBoy.Park(car);
            var parkedCar = parkingBoy.Pick(ticket);

            Assert.Same(car, parkedCar);
        }

        [Fact]
        public void should_be_able_to_pick_the_same_car_from_the_first_parking_lot_when_parking_boy_has_two_parking_lot_and_park_the_car()
        {
            var parkingLot1 = new ParkingLot(1);
            var parkingLot2 = new ParkingLot(1);
            var parkingBoy = new ParkingBoy(new[] {parkingLot1, parkingLot2});
            var car = new Car();

            var ticket = parkingBoy.Park(car);

            Assert.Same(car, parkingLot1.Pick(ticket));
        }
    }
}