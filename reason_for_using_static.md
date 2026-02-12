### What was added:
| What | Why |
|---|---|
| `public` | So code **outside** the class can call the methods |
| `static` | So you can call `Messages.Hello()` directly without creating an object |
| `Messages.Hello()` etc. at the top | Actually **runs** the methods — without this, nothing happens! |

> Think of it this way: Defining a class is like writing a **recipe book** 📖. But just having the book doesn't cook the food — you still need to **follow the recipe** (call the methods)!

Would you like me to apply this fix to your file?

### User Input

why do we use static keyword in this methods like public i understand we need to give access to other of our iinformatiion what about static ?

### Planner Response

Great question! Let me explain with a simple analogy.

## `static` vs non-static — The key difference

### **Without `static`** — You need to create an **object** first

```csharp
class Messages
{
    public void Hello()   // no static
    {
        Console.WriteLine("Hello!");
    }
}
```

To use it, you must **create an object** (a copy of the class):

```csharp
Messages msg = new Messages();   // create an object first
msg.Hello();                      // then call the method on that object
```

### **With `static`** — Call directly on the **class name**, no object needed

```csharp
class Messages
{
    public static void Hello()   // with static
    {
        Console.WriteLine("Hello!");
    }
}
```

Now you can call it **directly**:

```csharp
Messages.Hello();   // no object needed! Just use the class name directly
```

---

## 🏠 Real-life analogy

Think of a class as a **house blueprint** 🏗️:

| | Non-static | Static |
|---|---|---|
| Analogy | You must **build a house** first, then use the doorbell | The doorbell is at the **blueprint office** — anyone can press it |
| Code | `Messages msg = new Messages();` then `msg.Hello();` | `Messages.Hello();` |
| Belongs to | Each **individual object** | The **class itself** |

---

## When to use which?

| Use `static` when... | Use non-static when... |
|---|---|
| The method does the **same thing every time** | Each object needs **its own data** |
| Like: `Math.Round()`, `Console.WriteLine()` | Like: each `Car` has its own `color`, `speed` |
| Utility/helper methods | Object-oriented programming (OOP) |

### Example where static makes sense:
```csharp
// Math.Round() doesn't need an object — it just does math
double result = Math.Round(3.14);   // static — call directly
```

### Example where non-static makes sense:
```csharp
// Each car is different — needs its own object
Car myCar = new Car();
myCar.color = "Red";       // THIS car is red

Car yourCar = new Car();
yourCar.color = "Blue";    // THIS car is blue
```

---

## In YOUR [Messages](cci:2://file:///home/paarth/Documents/Playground/C%23/29_Classes/29_Classes/Program.cs:6:0-22:1) class:

Since [Hello()](cci:1://file:///home/paarth/Documents/Playground/C%23/29_Classes/29_Classes/Program.cs:8:4-11:5), [Waiting()](cci:1://file:///home/paarth/Documents/Playground/C%23/29_Classes/29_Classes/Program.cs:13:4-16:5), and [Bye()](cci:1://file:///home/paarth/Documents/Playground/C%23/29_Classes/29_Classes/Program.cs:18:4-21:5) just print the same message every time (no unique data per object), **`static` is the right choice** — there's no reason to create an object just to print a message! 👍

You'll learn more about non-static methods when your tutor covers **OOP (Objects)** — that's when things get really interesting! 🚀
