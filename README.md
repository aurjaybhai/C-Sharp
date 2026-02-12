<div align="center">

# 🚀 C# Fundamentals — From Zero to OOP Hero

**A hands-on, topic-by-topic guide to mastering C# and .NET**

![C#](https://img.shields.io/badge/C%23-12.0-blueviolet?style=for-the-badge&logo=csharp)
![.NET](https://img.shields.io/badge/.NET-9.0-blue?style=for-the-badge&logo=dotnet)
![Topics](https://img.shields.io/badge/Topics_Covered-49-brightgreen?style=for-the-badge)
![License](https://img.shields.io/badge/License-Educational-orange?style=for-the-badge)

*Each folder is a standalone console project covering a single C# concept — read the code, run it, learn it.*

</div>

---

## 📖 How to Use This Repository

1. **Browse** the topic table below and click any topic to jump to its detailed overview.
2. **Navigate** into the corresponding folder to read the commented source code.
3. **Run** any example with `dotnet run` from inside its project folder.
4. **📄 Look for the docs badge** — some folders contain an in-depth Markdown explanation you can read for a deeper understanding.

> **💡 Tip:** Use `Ctrl + F` to search for any keyword (e.g. *polymorphism*, *interface*, *static*) and jump directly to that section!

---

## 🗂️ Quick Navigation — All 49 Topics

| # | Topic | Category |
|:-:|-------|----------|
| [00](#00--hello-world) | Hello World | 🟢 Basics |
| [01](#01--output) | Output & Escape Sequences | 🟢 Basics |
| [02](#02--variables) | Variables & Data Types | 🟢 Basics |
| [03](#03--constants) | Constants | 🟢 Basics |
| [04](#04--type-casting) | Type Casting | 🟢 Basics |
| [05](#05--user-input) | User Input | 🟢 Basics |
| [06](#06--arithmetic-operators) | Arithmetic Operators | 🟡 Operators & Math |
| [07](#07--math-class) | Math Class | 🟡 Operators & Math |
| [08](#08--random-numbers) | Random Numbers | 🟡 Operators & Math |
| [09](#09--hypotenuse-calculator) | Hypotenuse Calculator *(mini-project)* | 🟡 Operators & Math |
| [10](#10--string-methods) | String Methods | 🔵 Strings |
| [11](#11--if-statements) | If / Else If / Else | 🟠 Control Flow |
| [12](#12--switch-statements) | Switch Statements | 🟠 Control Flow |
| [13](#13--logical-operators) | Logical Operators (`&&`, `\|\|`) | 🟠 Control Flow |
| [14](#14--while-loops) | While Loops | 🔴 Loops |
| [15](#15--for-loops) | For Loops | 🔴 Loops |
| [16](#16--nested-loops) | Nested Loops | 🔴 Loops |
| [17](#17--number-guessing-game) | Number Guessing Game *(mini-project)* | 🎮 Projects |
| [18](#18--rock-paper-scissors) | Rock Paper Scissors *(mini-project)* | 🎮 Projects |
| [19](#19--calculator-program) | Calculator Program *(mini-project)* | 🎮 Projects |
| [20](#20--arrays) | Arrays | 📦 Collections |
| [21](#21--methods) | Methods | 🔧 Methods |
| [22](#22--return-keyword) | Return Keyword | 🔧 Methods |
| [23](#23--method-overloading) | Method Overloading | 🔧 Methods |
| [24](#24--params-keyword) | `params` Keyword | 🔧 Methods |
| [25](#25--exception-handling) | Exception Handling (`try/catch/finally`) | ⚠️ Error Handling |
| [26](#26--conditional-operator) | Conditional (Ternary) Operator | 🟠 Control Flow |
| [27](#27--string-interpolation) | String Interpolation | 🔵 Strings |
| [28](#28--multidimensional-arrays) | Multidimensional Arrays | 📦 Collections |
| [29](#29--classes) | Classes | 🏛️ OOP |
| [30](#30--objects) | Objects | 🏛️ OOP |
| [31](#31--constructors) | Constructors | 🏛️ OOP |
| [32](#32--static-modifier) | Static Modifier | 🏛️ OOP |
| [33](#33--overloaded-constructors) | Overloaded Constructors | 🏛️ OOP |
| [34](#34--inheritance) | Inheritance | 🏛️ OOP |
| [35](#35--abstract-classes) | Abstract Classes | 🏛️ OOP |
| [36](#36--array-of-objects) | Array of Objects | 🏛️ OOP |
| [37](#37--objects-as-arguments) | Objects as Arguments | 🏛️ OOP |
| [38](#38--method-overriding) | Method Overriding (`virtual`/`override`) | 🏛️ OOP |
| [39](#39--tostring) | ToString() Override | 🏛️ OOP |
| [40](#40--polymorphism) | Polymorphism | 🏛️ OOP |
| [41](#41--interfaces) | Interfaces | 🏛️ OOP |
| [42](#42--lists) | Lists (`List<T>`) | 📦 Collections |
| [43](#43--list-of-objects) | List of Objects | 📦 Collections |
| [44](#44--getters--setters) | Getters & Setters (Properties) | 🏛️ OOP |
| [45](#45--auto-implemented-properties) | Auto-Implemented Properties | 🏛️ OOP |
| [46](#46--enums) | Enums | 🏛️ OOP |
| [47](#47--generics) | Generics (`<T>`) | 🧬 Advanced |
| [48](#48--multithreading) | Multithreading | 🧬 Advanced |

---

## 📚 Extra Documentation Files

Some concepts have **dedicated Markdown files** with in-depth explanations, analogies, and diagrams. These are invaluable for revision!

| 📄 File | Location | What You'll Learn |
|---------|----------|-------------------|
| [`Interfaces.md`](41_interfaces/41_interfaces/Interfaces.md) | `41_interfaces/41_interfaces/` | Complete interface breakdown — contract analogy, step-by-step code walkthrough, visual diagrams, interface vs method comparison, real-world pizza shop example |
| [`reason_for_using_static.md`](reason_for_using_static.md) | Root directory | Why and when to use `static` — house blueprint analogy, static vs non-static comparison table, practical use-case guidelines |

---

## 🟢 Basics

### 00 — Hello World
📂 [`00_Hello_World/Hello_World/Program.cs`](00_Hello_World/Hello_World/Program.cs)

Your very first C# program! Prints text to the console and makes a beep sound.

**Concepts:** `Console.WriteLine()` · `Console.Beep()`

---

### 01 — Output
📂 [`01_Output/Ouput/Program.cs`](01_Output/Ouput/Program.cs)

Explores different ways to output text and special characters.

**Concepts:**
- `Console.Write()` vs `Console.WriteLine()` — with and without newline
- Single-line (`//`) and multi-line (`/* */`) comments
- `Console.ReadKey()` — pause until key press
- **Escape Sequences:** `\a` `\b` `\f` `\n` `\r` `\t` `\v` `\'` `\"` `\\` `\?`

---

### 02 — Variables
📂 [`02_Variables/02_Variables/Program.cs`](02_Variables/02_Variables/Program.cs)

How to store and use data in C#.

**Concepts:**
- Declaration vs Initialization vs both in one line
- **Data types:** `int`, `double`, `bool`, `char`, `string`
- String concatenation with `+`

---

### 03 — Constants
📂 [`03_Constants/03_Constants/Program.cs`](03_Constants/03_Constants/Program.cs)

Immutable values that can never change after assignment.

**Concepts:** `const` keyword · compile-time constants · why constants matter (e.g., `pi`, `goldenratio`)

---

### 04 — Type Casting
📂 [`04_TypeCasting/04_TypeCasting/Program.cs`](04_TypeCasting/04_TypeCasting/Program.cs)

Converting between data types.

**Concepts:**
- `Convert.ToInt32()`, `Convert.ToDouble()`, `Convert.ToString()`, `Convert.ToChar()`, `Convert.ToBoolean()`
- `.GetType()` — inspecting a variable's type at runtime

---

### 05 — User Input
📂 [`05_UserInput/05_UserInput/Program.cs`](05_UserInput/05_UserInput/Program.cs)

Reading input from the keyboard.

**Concepts:** `Console.ReadLine()` · parsing user input with `Convert.ToInt32()`

---

## 🟡 Operators & Math

### 06 — Arithmetic Operators
📂 [`06_Arithmetic_Operators/06_Arithmetic_Operators/Program.cs`](06_Arithmetic_Operators/06_Arithmetic_Operators/Program.cs)

All the math operators in one place.

**Concepts:**
- Addition (`+`, `+=`, `++`), Subtraction (`-`, `-=`, `--`)
- Multiplication (`*`, `*=`), Division (`/`, `/=`)
- Modulus / Remainder (`%`)

---

### 07 — Math Class
📂 [`07_Match Class/07_Match Class/Program.cs`](07_Match%20Class/07_Match%20Class/Program.cs)

Built-in mathematical functions from `System.Math`.

**Concepts:** `Math.Pow()` · `Math.Sqrt()` · `Math.Abs()` · `Math.Round()` · `Math.Ceiling()` · `Math.Floor()` · `Math.Max()` · `Math.Min()`

---

### 08 — Random Numbers
📂 [`08_Random_Number/08_Random_Number/Program.cs`](08_Random_Number/08_Random_Number/Program.cs)

Generating pseudo-random numbers.

**Concepts:** `Random` class · `random.Next(min, max)` (inclusive min, exclusive max) · `random.NextDouble()` (0.0 to 1.0)

---

### 09 — Hypotenuse Calculator
📂 [`09_Hypotenuse_calculator/09_Hypotenuse_calculator/Program.cs`](09_Hypotenuse_calculator/09_Hypotenuse_calculator/Program.cs)

🧮 *Mini-project* — Calculates the hypotenuse of a right triangle using the Pythagorean theorem.

**Concepts:** Combining `Console.ReadLine()`, `Convert.ToDouble()`, and `Math.Sqrt()` in a real formula

---

## 🔵 Strings

### 10 — String Methods
📂 [`10_String_Methods/10_String_Methods/Program.cs`](10_String_Methods/10_String_Methods/Program.cs)

Essential string manipulation techniques.

**Concepts:** `.ToUpper()` · `.ToLower()` · `.Replace()` · `.Insert()` · `.Length` · `.Substring(startIndex, length)`

---

### 27 — String Interpolation
📂 [`27_string_interpolation/27_string_interpolation/Program.cs`](27_string_interpolation/27_string_interpolation/Program.cs)

A cleaner way to embed variables inside strings.

**Concepts:**
- `$"Hello {variable}"` syntax vs `+` concatenation
- Alignment / padding: `{age,10}` (right-align) and `{age,-10}` (left-align)

---

## 🟠 Control Flow

### 11 — If Statements
📂 [`11_if_statements/11_if_statements/Program.cs`](11_if_statements/11_if_statements/Program.cs)

Basic decision-making — branching logic.

**Concepts:** `if` · `else if` · `else` · comparison operators (`>`, `>=`, `<`, `!=`) · checking empty strings

---

### 12 — Switch Statements
📂 [`12_Switches/12_Switches/Program.cs`](12_Switches/12_Switches/Program.cs)

A cleaner alternative when checking one variable against many values.

**Concepts:** `switch` · `case` · `break` · `default` — day-of-week example

---

### 13 — Logical Operators
📂 [`13_Logical_operators/13_Logical_operators/Program.cs`](13_Logical_operators/13_Logical_operators/Program.cs)

Combining multiple conditions.

**Concepts:** `&&` (AND) · `||` (OR) — temperature range checker example

---

### 26 — Conditional Operator
📂 [`26_conditional_operator/26_conditional_operator/Program.cs`](26_conditional_operator/26_conditional_operator/Program.cs)

The shorthand ternary operator for one-line decisions.

**Concepts:** `(condition) ? valueIfTrue : valueIfFalse`

---

## 🔴 Loops

### 14 — While Loops
📂 [`14_while_loops/14_while_loops/Program.cs`](14_while_loops/14_while_loops/Program.cs)

Repeating code while a condition is true.

**Concepts:** `while` loop · forcing valid input · infinite loop warnings · `OperatingSystem.IsLinux()` / `.IsWindows()` for platform checks

---

### 15 — For Loops
📂 [`15_for_loop/15_for_loop/Program.cs`](15_for_loop/15_for_loop/Program.cs)

Repeating code a fixed number of times.

**Concepts:** `for` loop · increment by 1 (`i++`) · increment by 2 (`i += 2`) · countdown (`i--`)

---

### 16 — Nested Loops
📂 [`16_nested_loops/16_nested_loops/Program.cs`](16_nested_loops/16_nested_loops/Program.cs)

Loops inside loops — essential for grids and sorting algorithms.

**Concepts:** Drawing a rectangle pattern with user-defined rows, columns, and symbol

---

## 🎮 Mini-Projects

### 17 — Number Guessing Game
📂 [`17_number_guessing_game/17_number_guessing_game/Program.cs`](17_number_guessing_game/17_number_guessing_game/Program.cs)

🎲 Guess a random number between 1–100 with "too high" / "too low" hints.

**Concepts:** `Random`, `while` loops, `if/else`, guess counter, play-again loop

---

### 18 — Rock Paper Scissors
📂 [`18_rock_paper_scissors/18_rock_paper_scissors/Program.cs`](18_rock_paper_scissors/18_rock_paper_scissors/Program.cs)

✊✋✌️ Classic game against the computer.

**Concepts:** `Random`, `switch`, nested `if/else`, input validation with `.ToUpper()`, play-again mechanism

---

### 19 — Calculator Program
📂 [`19_calculator_program/19_calculator_program/Program.cs`](19_calculator_program/19_calculator_program/Program.cs)

🔢 A menu-driven calculator supporting `+`, `-`, `*`, `/`.

**Concepts:** `switch` on user input, `Convert.ToDouble()`, string interpolation for results

---

## 📦 Collections

### 20 — Arrays
📂 [`20_Arrays/20_Arrays/Program.cs`](20_Arrays/20_Arrays/Program.cs)

Fixed-size collections of elements.

**Concepts:**
- Declaration, initialization, and accessing by index
- Updating elements (`cars[0] = "Tesla"`)
- **4 ways to iterate:** `for` loop, `foreach`, `Array.ForEach()`, `string.Join()`

---

### 28 — Multidimensional Arrays
📂 [`28_multidimensional_arrays/28_multidimensional_arrays/Program.cs`](28_multidimensional_arrays/28_multidimensional_arrays/Program.cs)

2D arrays — think rows and columns (tables, grids, game boards).

**Concepts:**
- `string[,]` declaration and initialization
- Accessing with `[row, column]`
- `GetLength(0)` for rows, `GetLength(1)` for columns
- Nested `for` loop traversal
- Includes an ASCII visual diagram of the array layout

---

### 42 — Lists
📂 [`42_Lists/42_Lists/Program.cs`](42_Lists/42_Lists/Program.cs)

Dynamic collections that can grow and shrink — the go-to over arrays.

**Concepts:**
- `List<string>` — `Add()`, `Remove()`, `Insert()`, `Count`, `IndexOf()`, `Contains()`
- `Sort()`, `Reverse()`, `ToArray()`, `Clear()`
- Why `using System.Collections.Generic;` is needed
- Array vs List comparison

---

### 43 — List of Objects
📂 [`43_list_of_objects/43_list_of_objects/Program.cs`](43_list_of_objects/43_list_of_objects/Program.cs)

Storing custom objects inside a `List<T>`.

**Concepts:** `List<Player>` · adding objects to lists · `foreach` traversal · `ToString()` override for cleaner output

---

## 🔧 Methods

### 21 — Methods
📂 [`21_methods/21_methods/Program.cs`](21_methods/21_methods/Program.cs)

Reusable blocks of code.

**Concepts:** Defining and calling methods · parameters (`string`, `int`) · `void` return type · code reusability benefits

---

### 22 — Return Keyword
📂 [`22_return_keyword/22_return_keyword/Program.cs`](22_return_keyword/22_return_keyword/Program.cs)

Getting data back from a method.

**Concepts:** `return` keyword · changing `void` to a return type (`double`) · returning expressions directly vs storing in a variable

---

### 23 — Method Overloading
📂 [`23_method_overloading/23_method_overloading/Program.cs`](23_method_overloading/23_method_overloading/Program.cs)

Same method name, different parameters.

**Concepts:**
- Method **signature** = name + parameters
- `Multiply(a, b)` vs `Multiply(a, b, c)`
- `public` access modifier (methods are `private` by default!)
- Top-level statements vs traditional `class Program` approach

---

### 24 — Params Keyword
📂 [`24_params keyword/24_params keyword/Program.cs`](24_params%20keyword/24_params%20keyword/Program.cs)

Accept a variable number of arguments in a single method.

**Concepts:** `params double[]` · cleaner alternative to excessive method overloading · `foreach` to process all arguments

---

## ⚠️ Error Handling

### 25 — Exception Handling
📂 [`25_Exception_Handling/25_Exception_Handling/Program.cs`](25_Exception_Handling/25_Exception_Handling/Program.cs)

Gracefully handling runtime errors.

**Concepts:**
- `try` / `catch` / `finally` blocks
- Specific exceptions: `FormatException`, `DivideByZeroException`
- Generic `Exception` as a safety net
- `finally` block — always runs regardless of exceptions

---

## 🏛️ Object-Oriented Programming (OOP)

### 29 — Classes
📂 [`29_Classes/29_Classes/Program.cs`](29_Classes/29_Classes/Program.cs)

Organizing related code into reusable blueprints.

**Concepts:** Creating a class (`Messages`) · `public` and `static` modifiers · calling class methods · separate class files
> 📄 **Deep dive:** Read [`reason_for_using_static.md`](reason_for_using_static.md) for a detailed explanation of *when and why* to use `static` — includes house blueprint analogy and comparison table.

---

### 30 — Objects
📂 [`30_objects/30_objects/Program.cs`](30_objects/30_objects/Program.cs)

Creating instances from class blueprints.

**Concepts:** `new` keyword · fields (data) vs methods (actions) · creating multiple objects from one class · `public` access modifier

---

### 31 — Constructors
📂 [`31_constructors/31_constructors/Program.cs`](31_constructors/31_constructors/Program.cs)

Initializing objects with data at creation time.

**Concepts:** Constructor definition · `this` keyword · passing arguments during `new` · separate class files for `Car`

---

### 32 — Static Modifier
📂 [`32_static_modifier/32_static_modifier/Program.cs`](32_static_modifier/32_static_modifier/Program.cs)

Members that belong to the *class itself*, not to individual objects.

**Concepts:**
- `static` fields — shared across all instances (e.g., `numberOfCars` counter)
- `static` methods — called on the class name (`Car.StartRace()`)
- `static` classes — cannot be instantiated
> 📄 **See also:** [`reason_for_using_static.md`](reason_for_using_static.md) for analogies and use-case guidelines.

---

### 33 — Overloaded Constructors
📂 [`33_overloaded_constructors/33_overloaded_constructors/Program.cs`](33_overloaded_constructors/33_overloaded_constructors/Program.cs)

Multiple constructors with different parameter combinations.

**Concepts:** Constructor overloading · signature = name + parameters · Pizza example (with and without toppings)

---

### 34 — Inheritance
📂 [`34_inheritance/34_inheritance/Program.cs`](34_inheritance/34_inheritance/Program.cs)

Child classes receiving fields and methods from a parent class.

**Concepts:** `: base class` syntax · `Vehicle` → `Car`, `Bicycle`, `Boat` hierarchy · shared `go()` method and `speed` field

---

### 35 — Abstract Classes
📂 [`35_abstract_classes/35_abstract_classes/Program.cs`](35_abstract_classes/35_abstract_classes/Program.cs)

Classes that define incomplete blueprints — you can't instantiate them directly.

**Concepts:** `abstract` keyword · preventing generic base class instantiation · forcing subclasses to provide specific implementations · Vehicle race game analogy

---

### 36 — Array of Objects
📂 [`36_array_of_objects/36_array_of_objects/Program.cs`](36_array_of_objects/36_array_of_objects/Program.cs)

Storing multiple objects in an array.

**Concepts:** `Car[] garage` · anonymous object creation (`new Car("Mustang")` inline) · `foreach` loop over object arrays

---

### 37 — Objects as Arguments
📂 [`37_objects_as_arguments/37_objects_as_arguments/Program.cs`](37_objects_as_arguments/37_objects_as_arguments/Program.cs)

Passing objects to methods as parameters.

**Concepts:** Modifying object properties via methods · copying objects · local functions (no access modifiers allowed)

---

### 38 — Method Overriding
📂 [`38_method_overriding/38_method_overriding/Program.cs`](38_method_overriding/38_method_overriding/Program.cs)

Replacing inherited method behavior in a child class.

**Concepts:**
- `virtual` keyword on parent method
- `override` keyword on child method
- `Animal` → `Dog` (woof) / `Cat` (meow) example
- Methods must be `abstract`, `virtual`, or already overridden to be overridable

---

### 39 — ToString()
📂 [`39_To_string/39_To_string/Program.cs`](39_To_string/39_To_string/Program.cs)

Customizing how an object is displayed as text.

**Concepts:** `override string ToString()` · `Console.WriteLine(object)` calls `ToString()` behind the scenes

---

### 40 — Polymorphism
📂 [`40_Polymorphism/40_Polymorphism/Program.cs`](40_Polymorphism/40_Polymorphism/Program.cs)

Objects identified by more than one type — "many forms."

**Concepts:**
- Storing different child types in a parent-type array: `Vehicle[] vehicles = { car, bicycle, boat }`
- Calling overridden methods polymorphically
- A Dog is also a Canine, Animal, and Organism

---

### 41 — Interfaces
📂 [`41_interfaces/41_interfaces/Program.cs`](41_interfaces/41_interfaces/Program.cs)

Defining contracts that classes must follow.

**Concepts:**
- `interface IPrey` / `interface IPredator` — method contracts with no implementation
- A class can implement **multiple** interfaces: `Fish : IPrey, IPredator`
- Naming convention: prefix with `I`
- Benefits: security, multiple inheritance, plug-and-play

> 📄 **Deep dive:** Read [`Interfaces.md`](41_interfaces/41_interfaces/Interfaces.md) for a **complete, beginner-friendly explanation** — includes power outlet analogy, step-by-step code walkthrough, visual ASCII diagrams, real-world pizza delivery example, and interface vs method comparison table.

---

### 44 — Getters & Setters
📂 [`44_gettersANDsetters/44_gettersANDsetters/Program.cs`](44_gettersANDsetters/44_gettersANDsetters/Program.cs)

Encapsulating fields with controlled access.

**Concepts:**
- `private` field + `public` property
- `get` accessor returns a value · `set` accessor assigns a value
- `value` keyword inside `set`
- Adding validation logic (e.g., speed capped at 500)

---

### 45 — Auto-Implemented Properties
📂 [`45_auto_implemented_properties/45_auto_implemented_properties/Program.cs`](45_auto_implemented_properties/45_auto_implemented_properties/Program.cs)

Shorthand for properties when no extra logic is needed.

**Concepts:** `public string Model { get; set; }` — no backing field needed · comparison with manual getter/setter

---

### 46 — Enums
📂 [`46_Enums/46_Enums/Program.cs`](46_Enums/46_Enums/Program.cs)

Named integer constants for fixed sets of values.

**Concepts:**
- `enum Planets` with custom integer values
- Casting to `int`: `(int)Planets.Mars`
- `.ToString()` to get the name
- Practical example: calculating planet volume using `PlanetRadius` enum

---

## 🧬 Advanced Topics

### 47 — Generics
📂 [`47_generics/47_generics/Program.cs`](47_generics/47_generics/Program.cs)

Writing code that works with **any** data type.

**Concepts:**
- `<T>` type parameter
- Generic method: `DisplayElements<Thing>(Thing[] array)`
- One method works for `int[]`, `double[]`, `string[]` — no duplication!
- Traditional `class Program { static void Main() }` style used here

---

### 48 — Multithreading
📂 [`48_mutithreading/48_mutithreading/Program.cs`](48_mutithreading/48_mutithreading/Program.cs)

Running multiple tasks simultaneously.

**Concepts:**
- `using System.Threading;`
- `Thread.CurrentThread` — accessing the main thread
- Creating new threads: `new Thread(() => Method("name"))`
- `Thread.Start()` · `Thread.Sleep(1000)` — pausing for 1 second
- Lambda expressions for passing parameters to threads
- Concurrent countdown + count-up timer example

---

## 🗺️ Learning Path (Recommended Order)

```
🟢 Basics (00-05)
    ↓
🟡 Operators & Math (06-09)
    ↓
🔵 Strings (10, 27)
    ↓
🟠 Control Flow (11-13, 26)
    ↓
🔴 Loops (14-16)
    ↓
🎮 Mini-Projects (17-19) ← apply everything so far!
    ↓
📦 Arrays (20, 28)
    ↓
🔧 Methods (21-24)
    ↓
⚠️ Exception Handling (25)
    ↓
🏛️ OOP (29-41, 44-46)
    ↓
📦 Lists (42-43)
    ↓
🧬 Advanced (47-48)
```

---

## 🛠️ Prerequisites

- [**.NET SDK**](https://dotnet.microsoft.com/download) (version 6.0 or later)
- A code editor — [VS Code](https://code.visualstudio.com/) with the C# extension is recommended

## 🚀 How to Run Any Example

```bash
# 1. Clone the repository
git clone https://github.com/<your-username>/C-Sharp.git
cd C-Sharp

# 2. Navigate into any topic's project folder
cd 40_Polymorphism/40_Polymorphism

# 3. Run it
dotnet run
```

> **Note:** Each topic is a standalone .NET console project — just `cd` into the inner project folder and `dotnet run`!

---

## 📝 License

This project is for **educational purposes** — built while learning C# from the ground up. Feel free to fork, learn, and contribute!

---

<div align="center">

**⭐ If this helped you learn C#, consider giving it a star!**

*Made with ❤️ and lots of `Console.WriteLine()`*

</div>
