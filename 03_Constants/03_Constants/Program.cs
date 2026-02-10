// See https://aka.ms/new-console-template for more information

/*
Constants ===> immutable values which are known at compile time
                and do not change for the life of the program
*/

double pi = 3.14159;

pi = 450;

Console.WriteLine(pi); // this changes the pi value so we need constants

// let's use the constants so that no one can change

const double goldenratio = 1.618;
Console.WriteLine(goldenratio);

Console.ReadKey();


