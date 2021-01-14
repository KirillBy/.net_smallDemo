//Task: Proccess task in collection after they finishing
using System;
using System.Linq;
using System.Threading.Tasks;

namespace _2._6_AsyncBasis_TaskProccessingAfterFinishing
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await ProcessTasksAsync();
        }

        static async Task<int> DelayAndReturnAsync(int value)
        {
            await Task.Delay(TimeSpan.FromSeconds(value));
            return value;
        }

        static async Task ProcessTasksAsync()
        {
            //Creating array of Tasks
            Task<int> taskA = DelayAndReturnAsync(2);
            Task<int> taskB = DelayAndReturnAsync(3);
            Task<int> taskC = DelayAndReturnAsync(1);
            Task<int>[] tasks = new[] {taskA, taskB, taskC};
            Task[] proccessingTasks = tasks.Select(async t => 
            {
                var result = await t;
                Console.WriteLine(result);
            }).ToArray();

            // Wait for all processing tasks
            await Task.WhenAll(proccessingTasks);

        }
    }
}
