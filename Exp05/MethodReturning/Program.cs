using System;
using System.Threading.Tasks;

class Program
{
    static async Task DisplayMessage()
    {
        Console.WriteLine("Task Started");

        await Task.Delay(2000); // wait for 2 seconds

        Console.WriteLine("Task Completed");
    }

    static async Task Main()
    {
        await DisplayMessage();
    }
}