// See https://aka.ms/new-console-template for more information

/*
// Polymorphism ==> Greek word that means to "have many forms"
                    Objects can be identified by more than one type
                    Ex:- A Dog is also: Canine,Animal,Organism
*/


Car car = new Car();
Bicycle bicycle = new Bicycle();
Boat boat = new Boat();

// Car[] vehicles = {car,bicycle,boat} // ERROR: cannot convert expression of type "bicycle" & "boat" to type "car"
// To solve this problem by using polymorphism (find what they all have in common) (hint: same parent)

Vehicle[] vehicles = { car, bicycle, boat };

/*
If you need to create an array of different types of objects you have to find what they
have in common and then you can just that as a data type
*/

foreach (Vehicle vehicle in vehicles)
{
    vehicle.Go();
}


class Vehicle
{
    public virtual void Go()
    {
        
    }
}

class Car : Vehicle
{
    public override void Go()
    {
        Console.WriteLine("Car is moving...");
    }
}

class Bicycle : Vehicle
{
    public override void Go()
    {
        Console.WriteLine("Bicycle is moving...");
    }
}

class Boat : Vehicle
{
    public override void Go()
    {
        Console.WriteLine("Boat is moving...");
    }
}