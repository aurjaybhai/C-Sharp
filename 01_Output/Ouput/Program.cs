// See https://aka.ms/new-console-template for more information

Console.Write("Hey");
Console.WriteLine("Hello!");

// This is a commment

/*
This is a multi line comment
*/

Console.WriteLine("BroCode");

// ============================================
// Escape Sequences in C#
// ============================================
// An escape sequence is a combination of characters
// that represents a special character within a string.
// They all start with a backslash (\).

// \a  - Bell (alert) — makes a beep sound
Console.WriteLine("\a");

// \b  - Backspace — removes the previous character
Console.WriteLine("Hello\b World");  // Output: Hell World

// \f  - Form feed — advances to the next page (rarely used)
Console.WriteLine("Hello\fWorld");

// \n  - New line — moves to the next line
Console.WriteLine("Hello\nWorld");

// \r  - Carriage return — moves cursor to the beginning of the line
Console.WriteLine("Hello\rWorld");  // Output: World

// \t  - Horizontal tab — adds a tab space
Console.WriteLine("Hello\tWorld");  // Output: Hello   World

// \v  - Vertical tab — adds a vertical tab space
Console.WriteLine("Hello\vWorld");

// \'  - Single quotation mark
Console.WriteLine("It\'s a great day!");

// \"  - Double quotation mark
Console.WriteLine("He said \"Hello!\"");

// \\  - Backslash
Console.WriteLine("C:\\Users\\Paarth");

// \?  - Literal question mark
Console.WriteLine("What\?");

Console.ReadKey(); // the program ends only when you press some key