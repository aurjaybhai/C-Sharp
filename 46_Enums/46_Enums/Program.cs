// See https://aka.ms/new-console-template for more information
/*
Enums ==> special "class" that contains a set of named integer constants.
Use enums when you have values that you know will not change,
To get the integer value from an item, you must explicitly convert to an int

name = integer

*/

// here we are accessing the names of the planet 
Console.WriteLine($"{Planets.Mars} is a planet");
// if we need the associated integer with each of these named members
Console.WriteLine($"{Planets.Mars} is a planet #{(int)Planets.Mars}");

string name = PlanetRadius.Earth.ToString(); // If we're going to store this within a string variable
int radius = (int)PlanetRadius.Earth;
double volume = Volume(PlanetRadius.Earth);
                                             // we need to use the ToString() method 

Console.WriteLine($"Planet: {name}");
Console.WriteLine($"Radius: {radius}km");
Console.WriteLine($"Volume: {volume}km³");

static double Volume(PlanetRadius radius)
{
    double volume = (4.0/3.0) * Math.PI * Math.Pow((int)radius, 3);
    return volume;
}

enum Planets
{
    // this named members always start with 0 you can set custom number if you want
    Mercury = 1,
    Venus = 2,
    Earth = 3,
    Mars = 4,
    Jupiter = 5,
    Saturn = 6,
    Uranus = 7,
    Neptune = 8
}

enum PlanetRadius
{
    Mercury = 2440,
    Venus = 6052,
    Earth = 6371,
    Mars = 3390,
    Jupiter = 69911,
    Saturn = 58232,
    Uranus = 25362,
    Neptune = 24622
}

