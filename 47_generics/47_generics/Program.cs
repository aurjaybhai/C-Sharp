// See https://aka.ms/new-console-template for more information

/*
Generic = "not specific to a particular data type"
add <T> to : classes, methods, fields , etc 
allows for code resusability for different data types
*/
class Program{
    public static void Main(string[] args)
    {
        int[] intArray = { 1, 2, 3 };
        double[] doubleArray = { 1.0, 2.0, 3.0 };
        String[] stringArray = { "1", "2", "3" };

        DisplayElements(intArray);
        DisplayElements(doubleArray);
        DisplayElements(stringArray);
        
    }
    // should be DisplayElements to follow C# PascalCase naming convention for methods.
    // displayElements was written like this 
public static void DisplayElements<Thing>(Thing[] array)
{
    foreach (Thing item in array)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}
}


