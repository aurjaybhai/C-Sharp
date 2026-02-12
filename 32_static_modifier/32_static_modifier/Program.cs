// See https://aka.ms/new-console-template for more information

// Static ==> modifier to declare a static member , which belongs to the class itself
//            rather than to any specific object

Car car1 = new Car("Mustang");
Car car2 = new Car("Corvette");
Car car3 = new Car("Lambo");

Console.WriteLine(Car.numberOfCars); // Output: 3



/*
Console.WriteLine(car1.numberOfCars); // Output 1 
Console.WriteLine(car2.numberOfCars); // Output 1 (Each Car object has their own copy of the numberofCars field)
*/



/*
but when you declare it has static the NON STATIC objects(car1,car2,....) cannot access
the "numberOfCars" they all share through the class "Car"
*/

Car.StartRace();


/*
You can apply the static modifier to a class itself(static class Car {line 35})
but then you can't instantiate objects}
from this class ==> Car car1 = new Car("Mustang");
"You can't create objects from a static class"
*/

class Car
{
    string model;
    public static int numberOfCars;
    
    public  Car(string model)
    {
        this.model = model;
        numberOfCars++;
    }
    
    public static void StartRace()
    {
        Console.WriteLine("The race started...");
    }
}