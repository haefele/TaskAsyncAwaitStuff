using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WorkingWithTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Egal woher dieser Task kommt
            var task = Task.FromResult(3.14);

            task.Wait();

            var pi = task.Result;

            task.ContinueWith(t =>
            {
                Console.WriteLine($"Pi: {t.Result}");
            });

            #region Others

            var multipleTasks = new[]
            {
                Task.FromResult(3.14),
                Task.Delay(TimeSpan.FromSeconds(2))
            };

            Task.WaitAll(multipleTasks);

            //Task.WaitAny(multipleTasks);

            //Task.WhenAll(multipleTasks);
            //Task.WhenAny(multipleTasks);

            #endregion
        }
    }
}