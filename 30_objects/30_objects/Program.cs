// See https://aka.ms/new-console-template for more information


/*
Object ==> An instance of a class
            A class can be used as a blueprint to create objects (OOP)
            objects can have fields & methods (Characteristics & actions)
*/

Human human1 = new Human(); // In this case we did not use the static keyword we had declare object to use it
Human human2 = new Human();
human1.name = "Jonas";
human1.age = 20;

human1.Eat();
human1.Sleep();

human2.name = "Martha";
human2.age = 19;

human2.Eat();
human2.Sleep();

// we use here public keyword to access the methods but it's not recommended to use
// (according to the guy teaching me)
class Human
{
    public string name; // fields
    public int age;
    
    // methods
    public void Eat()
    {
        Console.WriteLine($"{name} is eating!");
    }

    public void Sleep()
    {
        Console.WriteLine($"{name} is sleeping!");
    }
}

