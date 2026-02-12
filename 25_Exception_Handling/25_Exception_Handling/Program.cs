// See https://aka.ms/new-console-template for more information

// Exception ==> errors that occurs during execution

// try = try some code that is considered "dangerous"
// catch = catches and handles exceptions when they occur
// finally = always executes regardless if exception is caught or not

int x;
int y;
int result;

try
{
    Console.Write("Enter 1st number: ");
    x = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter 2nd number: ");
    y = Convert.ToInt32(Console.ReadLine());

    result = x / y;

    Console.WriteLine($"Result: {result}");
}
catch (FormatException e)
{
    Console.WriteLine("invalid input(Enter only numbers)");
}
catch (DivideByZeroException e)
{
    Console.WriteLine("You cannot divide by zero! IDIOT!");
} // by chance if you miss any exception then can add a universal type exception
catch (Exception e)
{
    Console.WriteLine("Something went wrong...");
}
finally
{
    Console.WriteLine("Goodbye!");
}




