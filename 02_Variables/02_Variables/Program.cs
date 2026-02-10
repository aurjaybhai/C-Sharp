// See https://aka.ms/new-console-template for more information

// Creating a variable takes two steps : declaration and initialization

int x; // declaration
x = 121; //initialization

int y = 321; // declaration + initialization


Console.WriteLine(x);
Console.WriteLine(y);

Console.WriteLine(x + y);


int age = 25; // whole integer
double height = 172.5; // double can store decimal value
bool alive = true; // boolean (true or false)
//char symbol = 'a';
char symbol = '@'; // character(single character) if you add more than one (error)
string name = "Bro";
Console.WriteLine("Hello " + name);
Console.WriteLine("Your age is: " + age);
Console.WriteLine("Your height is: " + height + "cm");
Console.WriteLine("Are you alive? " + alive);
Console.WriteLine("Your symbol is: " + symbol);

string userName = symbol + name;

Console.WriteLine("Your userName is: " + userName);


Console.ReadKey();
