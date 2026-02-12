// See https://aka.ms/new-console-template for more information

string fullName = "Lisa Vicari";
string phoneNumber = "1548-5444";


fullName = fullName.ToUpper();
fullName = fullName.ToLower();

phoneNumber = phoneNumber.Replace("-","/"); // Replace(oldChar,newChar)
Console.WriteLine(phoneNumber);

// Insert Method

string userName = fullName.Insert(0, "Ms. ");
Console.WriteLine(userName); // Output : Ms. lisa vicari

Console.WriteLine(fullName.Length); // Don't put () after length that is done for methods

// Substring

string firstName = fullName.Substring(0, 4); // parameters(startindex,length)
string lastName = fullName.Substring(5, 6);
Console.WriteLine(firstName);
Console.WriteLine(lastName);

Console.ReadKey();



