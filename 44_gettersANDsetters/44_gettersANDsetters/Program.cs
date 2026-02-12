// See https://aka.ms/new-console-template for more information

/*
Getters & Setters ==> add security to fields by encapsulation
                      They're accessors found within properties

properties ==> combine aspects of both fields and methods (share name with a field)
get accessor ==> used to return the property value
set accessor ==> used to assign a new value
value keyword ==> defines the value being assigned by the set (parameter)
*/

Car car = new Car(400);

// if someone changes our car speed to like millions to prevent this from doing this(one way is to change the
// speed to private but then we can't access it and another way is to set up getters and setters)

car.Speed = 10000000;


Console.WriteLine(car.Speed); // here we need to access the property instead of field(speed)


class Car
{
    private int speed;

    public Car(int speed)
    {
        Speed = speed;  //  Captial S(Speed) is a property
    }
// getters and setters
    public int Speed
    {
        get { return speed; } // read the value(within our field)
        set
        {
            if (value > 500)
            {
                speed = 500;
            }
            else
            {
                speed = value;
            }
        } // value is kind of like a parameter
    }
    
    
}
