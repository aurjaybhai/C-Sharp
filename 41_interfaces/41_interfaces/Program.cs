// See https://aka.ms/new-console-template for more information


/*
Interface ==> defines a "contract" that all the classes inheriting from should follow
    An Interface declares "what a class should have"
    An inheriting class defines "how it should do it"
    Benefit = security + multiple inheritance + "plug-and-play"
*/

Rabbit rabbit = new Rabbit();
rabbit.Flee();

Hawk hawk = new Hawk();
hawk.Hunt();

Fish fish = new Fish();
fish.Flee();
fish.Hunt();

interface IPrey
{
    void Flee();
}

interface IPredator
{
    void Hunt();
}


class Rabbit : IPrey
{
    public void Flee()
    {
        Console.WriteLine("The Rabbit runs away");
    }
}

class Hawk : IPredator // It's a standard Practice to use character first
{
    public void Hunt()
    {
        Console.WriteLine("The Hawk is searching for food!");
    }
}

class Fish : IPrey,IPredator
{
    public void Flee()
    {
        Console.WriteLine("The Fish swims away!");
    }

    public void Hunt()
    {
        Console.WriteLine("The Fish is searching for smaller fish");
    }
}

