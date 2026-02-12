// See https://aka.ms/new-console-template for more information

/*
String interpolation = allow us to insert variables into string literal
                        precede a string literal with ${} are placeholders
*/

string firstName = "Lisa";
string lastName = "Vicari";
int age = 29;
// without string interpolation method
Console.WriteLine("Hello "+firstName + " " + lastName);

// with string interpolation method 

Console.WriteLine($"Hello {firstName} {lastName}");
Console.WriteLine($"You are {age} years old");
// You want to extra spaces before the age displays like : you are              29 years old

Console.WriteLine($"You are {age,10} old.");
// this can be negative also in that case the direction changes
Console.WriteLine($"You are {age,-10} old.");




