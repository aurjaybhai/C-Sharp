// See https://aka.ms/new-console-template for more information

// Method Overloading ==> methods share same name , but different parameters
// name + parameters = signature
// methods must have a unique signature


// Top-level statements (your main code)
double total;
total = MyMath.Multiply(2, 3, 4);
Console.WriteLine(total);



// class Program  : // When you use top-level statements (lines 9-11), the compiler already creates a hidden 
// Program class behind the scenes. So your class Program on line 14 conflicts with it — that's the error:
// (CS0260: Missing partial modifier on declaration of type 'Program')

class MyMath
{
    public static double Multiply(double a, double b)
    {
        return a * b;
    }

    public static double Multiply(double a, double b, double c)
    {
        return a * b * c;
    }
}

/*
If you don't add public in front of method 
    (CS0122: 'MyMath.Multiply(double, double)' is inaccessible due to its protection level)
*/

/*

The methods are missing the public keyword! In C#, methods are private by default — 
meaning only code inside the class can use them.
 You need to make them public so your top-level code can access them
 
 */

//  OLD .NET Method PREFERED BY AI

// class Program
// {
//     static void Main(string[] args)
//     {
//         double total;
//         total = Multiply(2, 3, 4);
//         Console.WriteLine(total);
//     }

//     static double Multiply(double a, double b) { return a * b; }
//     static double Multiply(double a, double b, double c) { return a * b * c; }
// }

