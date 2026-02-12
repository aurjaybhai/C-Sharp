// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter side A: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter side B: ");
double b = Convert.ToDouble(Console.ReadLine());

double c = Math.Sqrt((a * a) + (b * b));

Console.WriteLine("The Hypotenuse is: "+c);
