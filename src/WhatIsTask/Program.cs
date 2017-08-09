using System;
using System.Threading;
using System.Threading.Tasks;

namespace WhatIsTask
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asynchrone Operation die irgendwann mal fertig ist und vielleicht einen Wert zurückliefert

            Console.WriteLine("GO!");

            CountAsync();

            Thread.Sleep(TimeSpan.FromSeconds(5));

            #region Others
            Task<double> piTaskOne = GetPiAsyncOne();
            Task<double> piTaskTwo = GetPiAsyncTwo();
            Task<double> piTaskThree = GetPiAsyncThree();
            Task<double> piTaskFour = GetPiAsyncFour();
            
            Thread.Sleep(TimeSpan.FromSeconds(1));

            var task = piTaskOne;

            Console.WriteLine($"Status: {task.Status}");
            Console.WriteLine($"IsCompleted: {task.IsCompleted}");
            Console.WriteLine($"IsCancelled: {task.IsCanceled}");
            Console.WriteLine($"IsFauled: {task.IsFaulted}");
            Console.WriteLine($"Result: {task.Result}");
            #endregion
        }

        #region Stuff
        private static Task CountAsync()
        {
            return Task.Run(() =>
            {
                int counter = 0;
                for (int i = 0; i < 1_000_000_000; i++)
                {
                    counter += i;
                }

                Console.WriteLine(counter);
            });
        }

        private static Task<double> GetPiAsyncOne()
        {
            return Task.FromResult(3.14);
        }

        private static Task<double> GetPiAsyncTwo()
        {
            return Task.Factory.StartNew(() =>
            {
                return 3.14;
            });
        }

        private static Task<double> GetPiAsyncThree()
        {
            return Task.Run(() =>
            {
                return 3.14;
            });
        }

        private static async Task<double> GetPiAsyncFour()
        {
            return 3.14;
        }

        #endregion
    }
}