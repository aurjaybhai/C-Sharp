// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic; // You need to add this to use "LIST"

/*
List ==> data strucuture that represents a list of objects that can be accessed by index.
            Similar to array, but can dynamically increase/decrease in size
            using System.Collections.Generic;
            
            IT's similar to array not exactly but it waste more memory
*/

// It can add items there is no limit like array no fixed size 
List<string> food = new List<string>(); // food is the custom name you can keep

// Adding items in the list
food.Add("fries");
food.Add("pizza");
food.Add("cheese");
food.Add("tomato");
food.Add("pepper");
food.Add("sauce");
food.Add("fries");

// Removing the items in the list

food.Remove("fries");

// Inserting the items at some index values 
food.Insert(0, "sushi");
// Get the total count of items

// Console.WriteLine(food.Count);

// To find the index of a specfic item 

// Console.WriteLine(food.IndexOf("pepper"));

// To find the last index of element
Console.WriteLine(food.IndexOf("fries")); // 6

// To find whether this item contains or not
Console.WriteLine(food.Contains("pizza")); // True

// Sort the items in alphabetical order 

food.Sort();

// Reverse order

food.Reverse();



// Let's Convert our List into Array

string[] foodArray = food.ToArray();

foreach (string item in food)
{
    Console.WriteLine(item);
}

// To clear the items inside the items

food.Clear();

// Console.WriteLine(food[0]); // pizza
// Console.WriteLine(food[1]); // cheese
// Console.WriteLine(food[2]); // tomato



// Suggestions by the BADA CHACHA

/*
  42_Lists — Printing after clearing the list
   File: 
   Program.cs

   csharp
   food.Clear();                    // Line 55: clears EVERYTHING
   string[] foodArray = food.ToArray();  // Line 59: empty array
   foreach (string item in food)    // Line 61: prints NOTHING
   You call food.Clear() before the foreach loop, so nothing will print. Move Clear() after the loop,
    or comment it out if you want to see the list contents.
 */













//
// String[] food = new string[3];
//
// food[0] = "Pizza";
// food[1] = "hamburger";
// food[2] = "hotdog";
// food[3] = "cheese"; // you cannot add more than 3 items in this array bcoz it has fixed size
//                     // (System.IndexOutOfRangeException)
//
//
// foreach (string item in food)
// {
//     Console.WriteLine(item);
// }

