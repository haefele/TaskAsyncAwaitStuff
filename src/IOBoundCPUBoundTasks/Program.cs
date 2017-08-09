using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOBoundCPUBoundTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            // CPU Bound
            var cpuTask = Task.Run(() =>
            {
                int counter = 0;
                for (int i = 0; i < 1_000_000_000; i++)
                {
                    counter += i;
                }

                Console.WriteLine(counter);
            });
            cpuTask.Wait();


            // IO Bound
            using (var stream = File.Open(".\\Test.txt", FileMode.Create))
            {
                var data = Encoding.UTF8.GetBytes("Hallo Welt.");
                var ioTask = stream.WriteAsync(data, 0, data.Length);

                ioTask.Wait();
            }

            #region Others

            //var bullshitTask = Task.Run(() =>
            //{
            //    using (var stream = File.Open(".\\Test.txt", FileMode.Create))
            //    {
            //        var data = Encoding.UTF8.GetBytes("Hallo Welt.");
            //        stream.Write(data, 0, data.Length);
            //    }
            //});
            //bullshitTask.Wait();

            #endregion
        }
    }
}
