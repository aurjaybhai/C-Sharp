// See https://aka.ms/new-console-template for more information

// ToString() ==> converts an object to it's string representation so that it is suitable for display

Car car = new Car("Chevy", "Corvette", 2022, "blue");

// Console.WriteLine(car.ToString()); // you can just use car it will this step bts
Console.WriteLine(car);



class Car
{
    string make;
    string model;
    int year;
    string color;

    public Car(string make, string model, int year, string color)
    {
        this.make = make;
        this.model = model;
        this.year = year;
        this.color = color;
    }

    public override string ToString()
    {
        string message = $"This is a {make} {model}";
        return message;
    }
}

