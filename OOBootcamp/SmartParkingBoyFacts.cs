using Xunit;

namespace OOBootcamp
{
    public class SmartParkingBoyFacts
    {
        [Fact]
        public void should_be_able_to_pick_the_same_car_from_the_parking_lot_when_smart_parking_boy_park_the_car()
        {
            var parkingLot = new ParkingLot(1);
            var parkingBoy = new SmartParkingBoy(parkingLot);
            var car = new Car();

            var ticket = parkingBoy.Park(car);

            Assert.Same(car, parkingLot.Pick(ticket));
        }

        [Fact]
        public void should_be_able_to_pick_the_same_car_by_parking_boy_when_smart_parking_boy_park_the_car()
        {
            var parkingLot = new ParkingLot(1);
            var parkingBoy = new SmartParkingBoy(parkingLot);
            var car = new Car();

            var ticket = parkingBoy.Park(car);
            var parkedCar = parkingBoy.Pick(ticket);

            Assert.Same(car, parkedCar);
        }

        [Fact]
        public void should_be_able_to_pick_the_same_car_from_the_first_parking_lot_when_smart_parking_boy_has_two_parking_lot_and_park_the_car()
        {
            var parkingLot1 = new ParkingLot(1);
            var parkingLot2 = new ParkingLot(1);
            var parkingBoy = new SmartParkingBoy(parkingLot1, parkingLot2);
            var car = new Car();

            var ticket = parkingBoy.Park(car);

            Assert.Same(car, parkingLot1.Pick(ticket));
        }

        [Fact]
        public void should_be_able_to_pick_the_same_car_from_the_second_parking_lot_when_smart_parking_boy_has_two_parking_lot_with_first_one_full_and_park_the_car()
        {
            var parkingLot1 = new ParkingLot(1);
            parkingLot1.Park(new Car());
            var parkingLot2 = new ParkingLot(1);
            var parkingBoy = new SmartParkingBoy(parkingLot1, parkingLot2);
            var car = new Car();

            var ticket = parkingBoy.Park(car);

            Assert.Same(car, parkingLot2.Pick(ticket));
        }

        [Fact]
        public void should_be_able_to_pick_the_same_car_by_smart_parking_boy_when_parking_boy_has_two_parking_lot_with_first_one_full_and_park_the_car()
        {
            var parkingLot1 = new ParkingLot(1);
            parkingLot1.Park(new Car());
            var parkingLot2 = new ParkingLot(1);
            var parkingBoy = new SmartParkingBoy(parkingLot1, parkingLot2);
            var car = new Car();

            var ticket = parkingBoy.Park(car);
            var parkedCar = parkingBoy.Pick(ticket);

            Assert.Same(car, parkedCar);
        }

        [Fact]
        public void should_fail_to_park_car_when_all_parking_lots_are_full()
        {
            var parkingLot1 = new ParkingLot(1);
            parkingLot1.Park(new Car());
            var parkingLot2 = new ParkingLot(1);
            parkingLot2.Park(new Car());
            var parkingBoy = new SmartParkingBoy(parkingLot1, parkingLot2);

            Assert.Throws<AllParkingLotsFullException>(() => parkingBoy.Park(new Car()));
        }

        [Fact]
        public void should_be_able_to_pick_the_same_car_from_the_parking_lot_with_maximum_vacancy_count()
        {
            var parkingLotWithLessVacancyCount = new ParkingLot(1);
            var parkingLotWithMoreVacancyCount = new ParkingLot(2);
            var smartParkingBoy = new SmartParkingBoy(parkingLotWithLessVacancyCount, parkingLotWithMoreVacancyCount);
            var car = new Car();

            var ticket = smartParkingBoy.Park(car);

            Assert.Same(car, parkingLotWithMoreVacancyCount.Pick(ticket));
        }

        [Fact]
        public void should_be_able_to_pick_the_same_car_from_the_parking_lot_with_maximum_vacancy_count_and_no_relationship_with_the_parking_lot_order()
        {
            var parkingLotWithLessVacancyCount = new ParkingLot(1);
            var parkingLotWithMoreVacancyCount = new ParkingLot(2);
            var smartParkingBoy = new SmartParkingBoy(parkingLotWithMoreVacancyCount, parkingLotWithLessVacancyCount);
            var car = new Car();

            var ticket = smartParkingBoy.Park(car);

            Assert.Same(car, parkingLotWithMoreVacancyCount.Pick(ticket));
        }
    }
}