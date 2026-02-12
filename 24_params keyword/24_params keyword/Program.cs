// See https://aka.ms/new-console-template for more information

/*
Params Method ==> a method parameter that takes a variable number of arguments
The parameter type must be a single - dimensional array
*/

// A single method can accept a varying amount of arguments
// (if you use method overloading the code becomes messy)


double total = Checkout(3.99,5.75,15);
Console.WriteLine(total);


static double Checkout(params double[] prices)
{
    double total = 0;

    foreach (double price in prices)
    {
        total += price;
    }
    
    return total;
}

