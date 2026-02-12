// See https://aka.ms/new-console-template for more information

// string[] ford = {"Mustang","F-150","Explorer"};
// string[] chevy = {"Corvette","Camaro","Silverado"};
// string[] toyota = {"Corolla", "Camry","ebella"};

// with multidimensional array it will make our life easier

string[,] parkingLot =
{
    {"Mustang","F-150","Explorer"},
    {"Corvette","Camaro","Silverado"},
    {"Corolla", "Camry","ebella"}
};

// if you want to change any of the model of the car then

parkingLot[0, 2] = "Fusion"; // [row,column] we changed the "Explorer" to "Fusion"

parkingLot[2, 0] = "Tacoma"; // we changed "Corolla" to "Tacoma"

// let's display

/*
foreach (string car in parkingLot)
{
    Console.WriteLine(car);
}
*/


for (int i = 0; i < parkingLot.GetLength(0); i++)
{
    for (int j = 0; j < parkingLot.GetLength(1); j++)
    {
        Console.Write(parkingLot[i, j] + " ");
    }
    Console.WriteLine();
}


/*
               Column 0      Column 1      Column 2
            ┌─────────────┬─────────────┬─────────────┐
  Row 0     │  "Mustang"  │   "F-150"   │  "Fusion"   │
            ├─────────────┼─────────────┼─────────────┤
  Row 1     │  "Corvette" │  "Camaro"   │ "Silverado" │
            ├─────────────┼─────────────┼─────────────┤
  Row 2     │  "Tacoma"   │   "Camry"   │  "ebella"   │
            └─────────────┴─────────────┴─────────────┘

*/


/*

This array has 2 dimensions:

Dimension 0 → Rows (going ↓ down) → 3 rows
Dimension 1 → Columns (going → right) → 3 columns

*/

