using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncVoidAsyncTask
{
    class Program
    {
        static void Main(string[] args)
        {
            AsyncVoid();

            Thread.Sleep(TimeSpan.FromSeconds(3));
        }

        private static async Task AsyncTask()
        {
            Console.WriteLine("Vor dem await");

            await Task.Delay(TimeSpan.FromSeconds(2));

            Console.WriteLine("Nach dem await");
        }

        private static async void AsyncVoid()
        {
            Console.WriteLine("Vor dem await");

            await Task.Delay(TimeSpan.FromSeconds(2));

            Console.WriteLine("Nach dem await");
        }
    }
}
