using System;
using System.Threading.Tasks;

namespace AsyncAwaitExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var task = DoSomething();

            task.Wait();
        }

        private static async Task DoSomething()
        {
            int i = int.Parse(Console.ReadLine());

            await Task.Delay(TimeSpan.FromSeconds(2));
            //Thread.Sleep(TimeSpan.FromSeconds(2));

            await DownloadImage();
            await ReadFile();

            Console.WriteLine(i + 1);
        }

        private static Task DownloadImage()
        {
            return Task.Delay(TimeSpan.FromSeconds(2));
        }

        private static Task ReadFile()
        {
            return Task.Delay(TimeSpan.FromSeconds(2));
        }
    }
}