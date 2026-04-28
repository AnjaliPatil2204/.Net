using System;
using System.Threading.Tasks;

class Program
{
    static async Task Work1()
    {
        Console.WriteLine("Work 1 Started");
        await Task.Delay(2000);
        Console.WriteLine("Work 1 Finished");
    }

    static async Task Work2()
    {
        Console.WriteLine("Work 2 Started");
        await Task.Delay(2000);
        Console.WriteLine("Work 2 Finished");
    }

    static async Task Main()
    {
        Task t1 = Work1();
        Task t2 = Work2();

        await Task.WhenAll(t1, t2);
    }
}