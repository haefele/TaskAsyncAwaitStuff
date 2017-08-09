using System;
using System.Threading;
using System.Threading.Tasks;

namespace ExceptionsInTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            var task = DoSomething();

            Thread.Sleep(TimeSpan.FromSeconds(1));

            Console.WriteLine($"Status: {task.Status}");

            Console.WriteLine($"IsCompleted: {task.IsCompleted}");
            Console.WriteLine($"IsCancelled: {task.IsCanceled}");
            Console.WriteLine($"IsFauled: {task.IsFaulted}");

            Console.WriteLine($"Exception: {task.Exception}");

            //task.Wait();
        }
        
        private static Task DoSomething()
        {
            return Task.Run(() =>
            {
                throw new Exception("Upsi!");
            });
        }
    }
}