#Parking Lot

Given a parking lot and a car
When park the car to the parking lot
Then will be able to pick the car from the parking lot

Given the parking lot is full
When park a car to the parking lot
Then will fail to park the car

Given the parking lot is full
When pick a car from the parking lot
Then will be able to park a car to the parking lot

Given picked a car parked in the parking lot
When pick the same car from the parking lot
Then will fail to pick the car

Given a parking lot
When pick a not-parked car from the parking lot
Then will fail to pick the car

Given a parking lot is not full
When park two cars
Then will be able to pick the two cars


#Parking Boy

Given a parking boy and a parking lot
When a parking boy park the car to a parking lot
Should be able to pick the same car from the parking lot

Given a parking boy and a parking lot
When the parking boy park the car
Should be able to pick the same car by the parking boy

Given a parking boy and two parking lots and one onf the parking lot is full
When the parking boy park the car
Should be able to pick the same car by the parking boy

Given a parking boy and two full parking lots
When the parking boy park the car
Should fail to park the car