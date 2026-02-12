// See https://aka.ms/new-console-template for more information

/*
Auto-Implemented properties = shortcut when no additional logic is required in the property
                              you do not have to define a field for a property,
                              you only have to write get; and/or set; inside the property
*/

Car car = new Car("Porsche");

Console.WriteLine(car.Model);



class Car
{

    public String Model { get; set; } // auto-implemented properties this will do the same
    // thing below commented code did 
    
    
    
    // string model;
    //
    // public string Model
    // {
    //     get { return model; }
    //     set { model = value; }
    // }

    public Car(string model)
    {
        this.Model = model;
    }
}