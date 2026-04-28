/* 
Synchronous Programming :
    - meaning each step waits for the previous one to finish, no parallel threads, no async/await.
      By default, C# runs synchronously, so unless you use async, Task, or threads, your code executes line by line.
 */

using System;

class Program
{
    static void Step1()
    {
        Console.WriteLine("Step 1: Starting");
        System.Threading.Thread.Sleep(1000); // simulate work for 1 second
        Console.WriteLine("Step 1: Completed");
    }

    static void Step2()
    {
        Console.WriteLine("Step 2: Starting");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine("Step 2: Completed");
    }

    static void Step3()
    {
        Console.WriteLine("Step 3: Starting");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine("Step 3: Completed");
    }

    static void Main()
    {
        Console.WriteLine("Program Started");

        Step1(); // runs first
        Step2(); // waits until Step1 finishes
        Step3(); // waits until Step2 finishes

        Console.WriteLine("Program Finished");
        Console.ReadLine(); // keep console open
    }
}