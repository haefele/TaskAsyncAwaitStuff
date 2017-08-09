using System;
using System.Threading;
using System.Threading.Tasks;

namespace CreatingTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            var task1 = Task.FromResult(3.14);
            
            var task2 = Task.Factory.StartNew(() =>
            {
                // Do stuff here
            });
            
            var task3 = Task.Run(() =>
            {
                // Do stuff here
            });
            
            var task4 = AsyncAwaitStuff();

            #region Others
            // Erklärung wie es funktioniert, Threadpool

            // Automatisches wachsen vom Threadpool
            // Warum Threadpool? (Thread overhead)
            #endregion

            #region Others
            // Unterschied Task.Factory.StartNew und Task.Run
            var taskFromFactory = Task.Factory.StartNew(async () =>
            {
                await AsyncAwaitStuff();
            });
            
            // taskFromFactory = Task<Task>
            // taskFromFactory.Unwrap();

            var taskFromRun = Task.Run(async () =>
            {
                await AsyncAwaitStuff();
            });

            // taskFromRun = Task
            #endregion

            #region Others
            // Hot und Cold Tasks

            // Niemals folgendes machen
            var evilTask = new Task(() =>
            {
            });
            #endregion
        }

        private static async Task AsyncAwaitStuff()
        {
            // Do stuff here
        }
    }
}