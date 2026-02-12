namespace _31_constructors;

public class Car
{
    string make;
    string model;
    int year;
    string color;
    
    // Constructor
    public Car(string make, string model, int year, string color)
    {
        this.make = make;
        this.model = model;
        this.year = year;
        this.color = color;
    }

    public void Drive()
    {
        Console.WriteLine($"You drive the {make}  {model}!");
    }
}