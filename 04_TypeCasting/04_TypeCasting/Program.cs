// See https://aka.ms/new-console-template for more information

/*
type casting ==> Converting a value to a different data type Useful when we accept user input(string)
                Different data types can do different things
*/

double a = 3.14;
int b = Convert.ToInt32(a);

// Now let's convert the int datatype to double 
int c = 222;
double d = Convert.ToDouble(c) + 0.1;

int e = 325;
string f = Convert.ToString(e);

string g = "$";
char h = Convert.ToChar(g);

string i = "true";
bool j = Convert.ToBoolean(i);

// To get the dataType of a variable 
Console.WriteLine(a.GetType());
Console.WriteLine(f.GetType());
Console.WriteLine(j.GetType());
// Seeing the result of b 
Console.WriteLine(b);
Console.WriteLine(h);
Console.WriteLine(j);
Console.WriteLine(d); // Normally it will not display like 222.0 so you need to add 0.1



