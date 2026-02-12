// See https://aka.ms/new-console-template for more information

// While loop ==> repeats some code while some condition remains true


string name = "";

while (name == "") // forcing a user to type a name keeps asking until the user types something
{
    Console.Write("Enter your name: ");
    name = Console.ReadLine();
}

// while (1 == 1)
// {
//     Console.WriteLine("Help! I am stuck in infinite loop!!");
// } // If you don't comment out this code then you will not be able to execute other
// lines below bcoz you are stuck in the infinte loop


Console.WriteLine($"Hello, {name}");


// Seperate topic from the while loop just wrote for fun
if (OperatingSystem.IsLinux())
{
    Console.Beep();
}
else if (OperatingSystem.IsWindows())
{
    Console.WriteLine("Oh You are bill consumer...");
}
else
{
    Console.WriteLine($"You are unique!");
}


