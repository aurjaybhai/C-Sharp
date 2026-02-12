// See https://aka.ms/new-console-template for more information

// how to pass an object as an argument


Car car1 = new Car("Mustang", "red");

ChangeColor(car1,"silver");

Car car2 = Copy(car1);

Console.WriteLine($"{car1.color} {car1.model}");
Console.WriteLine($"{car2.color} {car2.model}");


/*
And local functions cannot have access modifiers like public or private
*/

static void ChangeColor(Car car, string color)
{
    car.color = color;
}

static Car Copy(Car car) // let's create a method to create a copy of car1
{
    return new Car(car.model, car.color);
}

class Car
{
    // public string Model { get; set; }
    public string model;
    public string color;

    public Car(string model, string color)
    {
        this.model = model;
        this.color = color;
    }
}

