// See https://aka.ms/new-console-template for more information

// this are not true random numbers rather "pseudo random numbers"

Random random = new Random();

int num1 = random.Next(1,7); // Generates a random number between 1 to 6
int num2 = random.Next(1,7); // Generates a random number between 1 to 6
int num3 = random.Next(1,7); // Generates a random number between 1 to 6
// If you want random number between 100 to 106 
int number = random.Next(1,7) + 100;

double Number = random.NextDouble(); // generates a random number between 0 to 1




Console.WriteLine(num1);
Console.WriteLine(num2);
Console.WriteLine(num3);

