using System;
using System.Threading.Tasks;

namespace Chapter_1_Listing_1_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<Int32[]> parent = Task.Run(() =>
            {
                var results = new Int32[3];
                new Task(() => results[0] = 0,
                TaskCreationOptions.AttachedToParent).Start();

                new Task(() => results[1] = 1,
                TaskCreationOptions.AttachedToParent).Start();

                new Task(() => results[2] = 2,
                TaskCreationOptions.AttachedToParent).Start();

                return results;
            });

            var finalTask = parent.ContinueWith(
                parentTask => {
                    foreach (int i in parentTask.Result)
                    {
                        Console.WriteLine(i);
                    }
                });
            finalTask.Wait();
        }
    }
}
