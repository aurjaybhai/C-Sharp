// See https://aka.ms/new-console-template for more information

// Car[] garage = new Car[3];
//
// Car car1 = new Car("Mustang");
// Car car2 = new Car("Corvette");
// Car car3 = new Car("Ferrari");
//
// garage[0] = car1;
// garage[1] = car2;
// garage[2] = car3;

// another way to do is through anonymous objects 

Car[] garage = {new Car("Mustang"),new Car("Corvette"),new Car("Ferrari")};
    
    
foreach (Car car in garage)
{
    Console.WriteLine(car.model);
}


// Console.WriteLine(garage[0]); // Car to get the model see below
// Console.WriteLine(garage[0].model);
// Console.WriteLine(garage[1].model);
// Console.WriteLine(garage[2].model);

class Car
{
    public string model;
    
    public Car (string model)
    {
        this.model = model;
    }
}









