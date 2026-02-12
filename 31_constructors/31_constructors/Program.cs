// See https://aka.ms/new-console-template for more information


/*
Constructor ===> A special method in a class
                Same name as the class name
                Can be used to assign arguments to fields when creating an object
*/

using _31_constructors;

Human human1 = new Human("Jonas",20); // In this case we did not use the static keyword we had declare object to use it
Human human2 = new Human("Martha",19);
/*
if we use the constructor then no need assign like this
human1.name = "Jonas";
human1.age = 20;
human2.name = "Martha";
human2.age = 19;
*/

human1.Eat();
human1.Sleep();


human2.Eat();
human2.Sleep();

Car car1 = new Car("Ford","Mustang",2022,"red"); // It has seperate class file
Car car2 = new Car("Chevy","Corvette",2021,"blue");
// let car1 use the drive method
car1.Drive();
car2.Drive();


// we use here public keyword to access the methods but it's not recommended to use
// (according to the guy teaching me)
class Human
{
    public string name; // fields
    public int age;
    
    // constructor
    public Human(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    
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