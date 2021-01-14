using System;
using System.Threading.Tasks;

namespace _2._11_AsyncBasis_GettingResultFromValueTask
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await ConsumingMethodAsync();
            await ConsumingMethodAsync2();
            await ConsumingMethodAsync3();
            await ConsumingMethodAsync4();
        }

        static async ValueTask<int> MethodAsync()
        {
            await Task.Delay(3000);
            return 12;
        }
        static async Task ConsumingMethodAsync()
        {
            int value = await MethodAsync();
            Console.WriteLine(value);
        }
        static async Task ConsumingMethodAsync2()
        {
            ValueTask<int> valueTask = MethodAsync();
            //anouther parallel work
            int value = await valueTask;
            Console.WriteLine(value);
        }

        //Converting ValueTask to Task
        static async Task ConsumingMethodAsync3()
        {
            Task<int> task = MethodAsync().AsTask();
            //anouther parallel work
            int value = await task;
            Console.WriteLine(value);
        }

        static async Task ConsumingMethodAsync4()
        {
            Task<int> task1 = MethodAsync().AsTask();
            Task<int> task2 = MethodAsync().AsTask();
            int[] results = await Task.WhenAll(task1, task2);
            Console.WriteLine(results[0] + results[1]);
        }
    }
}
