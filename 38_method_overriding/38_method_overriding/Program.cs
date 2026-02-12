// See https://aka.ms/new-console-template for more information

/*
Method Overriding ==> provides a new version of a method inherited from a parent class
                      inherited method must be : abstract , virtual , or already overriden
                      Used with ToString(), polymorphism
*/


Dog dog = new Dog();
Cat cat = new Cat();

dog.Speak();
cat.Speak();



class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("The animal goes *brrr*");
    }
}

class Dog : Animal
{
    // We can override the speak from the animal create our custom
    //  the method which inherited must be : abstract , virtual , or already overriden
    public override void Speak()
    {
        Console.WriteLine("The dog says *woof*");
    }
    
}

class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("The cat says *meow*");
    }
}

