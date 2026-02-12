// See https://aka.ms/new-console-template for more information

// Abstract Classes ==> modifier that indicates missing components or incomplete implementation


Car car = new Car();
Bicycle bicycle = new Bicycle();
Boat boat = new Boat();
// Vehicle vehicle = new Vehicle();

Console.WriteLine(car.speed);
Console.WriteLine(car.wheels);
car.go();

Console.WriteLine(bicycle.speed);
Console.WriteLine(bicycle.wheels);
bicycle.go();

Console.WriteLine(boat.speed);
Console.WriteLine(boat.wheels);
boat.go();

/*
So we use abstract in front on "Vehicle" class bcoz Vehicle has missing some properties "number of wheels"
    and a max speed (imagine a race game someone picks Vehicle) but we want to pick a specific implementation
    of vehicle so to prevent from creating a generic Vehicle object
*/


abstract class Vehicle
{
    public int speed = 0;

    public void go()
    {
        Console.WriteLine("The vehicle is moving...");
    }
}

class Car : Vehicle // We are inheriting the values from Car(parent)
{
    public int wheels = 4;
    int maxSpeed = 500;
}

class Bicycle :  Vehicle
{
    public int wheels = 2;
    int maxSpeed = 50;
}

class  Boat : Vehicle
{
    public int wheels = 0;
    int maxSpeed = 100;
}