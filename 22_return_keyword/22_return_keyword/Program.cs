// See https://aka.ms/new-console-template for more information

// Return ==> returns data back to the place where a method is invoked

double x;
double y;
double result;

Console.WriteLine("Enter 1st number: ");
x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter 2nd number: ");
y = Convert.ToDouble(Console.ReadLine());

result = Multiply(x, y);

Console.WriteLine($"The result is: {result}");

static double Multiply(double x, double y)
{
    // double z = x * y; # Method 1 
    // return z; // if you return something in a method then change "void" to return data type
    
    return x * y;
}



