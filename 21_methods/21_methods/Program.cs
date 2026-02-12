// See https://aka.ms/new-console-template for more information

// Method = performs a section of code, whenever it's called "invoked".
// benefit = Let's us reuse code without(w/o) writing it multiple times 


string name = "Lisa Vicari";
int age = 29;
singHapppyBirthday(name,age);

// what i have written oustide the singHappyBirthday is Main static(static void Main(string[] args))
static void singHapppyBirthday(string birthdayGirl, int age)
{
    Console.WriteLine("Happy Birthday to you..");
    Console.WriteLine("Happy Birthday to you..");
    Console.WriteLine($"Happy Birthday dear {birthdayGirl}!");
    Console.WriteLine($"Your are now {age} years old");
    Console.WriteLine("Happy Birthday dear YOU!");
}
