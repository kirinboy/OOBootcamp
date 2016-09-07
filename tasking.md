Given I have a parking lot and a car
When I park the car to the parking lot
Then I will be able to pick the car from the parking lot

Given the parking lot is full
When I park a car to the parking lot
Then I will fail to park the car

Given the parking lot is full
When I pick a car from the parking lot
Then I will be able to park a car to the parking lot

Given I pick a car parked in the parking lot
When I try to pick the same car from the parking lot
Then I will fail to pick the car

Given I have a parking lot
When I try to pick a not-parked car from the parking lot
Then I will fail to pick the car