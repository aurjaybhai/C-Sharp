// See https://aka.ms/new-console-template for more information

Console.WriteLine("What's your name?");
string name = Console.ReadLine();
// taking the user input from the user and converting into INT
Console.WriteLine("What's your age?");
int age = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Hello "+ name);
Console.WriteLine("You are "+ age + " years old");
