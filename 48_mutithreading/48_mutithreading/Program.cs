// See https://aka.ms/new-console-template for more information

using System;
using System.Threading;
/*
Thread ==> An execution path of a program
we can use multiple threads to perform,
different tasks of our program at the same time
Current thread running is "main" thread
using System.Threading;
*/

Thread mainThread = Thread.CurrentThread;
mainThread.Name = "MainThread";

// If you want to run both countdown and countUp at same time at different threads 
// Thread thread1 = new Thread(Countdown); when you don't but the string name parameter in the method
// Thread thread2 = new Thread(CountUp);

Thread thread1 = new Thread(() => Countdown("Timer #1"));
Thread thread2 = new Thread(() => CountUp("Timer #2"));
thread1.Start();
thread2.Start();


// Countdown();
// CountUp();
Console.WriteLine(mainThread.Name + " is completed");

 static void Countdown(string name)
{
    for (int i = 10; i >= 0; i--)
    {
        Console.WriteLine($"Timer #1 {i} seconds");
        Thread.Sleep(1000);
    }
    Console.WriteLine("Timer #1 : is completed");
}

 static void CountUp(string name)
{
    for (int i = 0; i <= 10; i++)
    {
        Console.WriteLine($"Timer #2 : {i} seconds");
        Thread.Sleep(1000);
    }
    Console.WriteLine("Timer #2 : is completed");
}

