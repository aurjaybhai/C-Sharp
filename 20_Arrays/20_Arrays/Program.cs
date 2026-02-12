// See https://aka.ms/new-console-template for more information

// Array = A variable that can store multiple values . fixed size

// If you plan to add things to an array you need to define it's length bcoz it's fixed size 
string[] manga = new string[3];


string[] cars = { "BMW", "Ford", "Toyota","Mustang", "Volkswagen","Corvette","Porsche"};

Console.WriteLine(cars); // Output : System.String[]

// To update any array position or replace
cars[0] = "Tesla";

// If you want to access the values inside the array then see below line
Console.WriteLine(cars[0]); // "Tesla"
Console.WriteLine(cars[1]); // "Ford"

// To display all array values 

// # Method 1 

for (int i = 0; i < cars.Length; i++)
{
    Console.WriteLine(cars[i]);
}


// # Method 2 
// foreach (string car in cars)
// {
//     Console.WriteLine(car);
// }

// # Method 3

Array.ForEach(cars, Console.WriteLine);

// # Method 4 (to print in one line)

Console.WriteLine(string.Join(", ", cars));

