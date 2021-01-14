//Task: to return ValueTask from async method
using System;
using System.Threading.Tasks;

namespace _2._10_AsyncBasis_CreationOfValueTask
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var result = await MethodAsync();
            Console.WriteLine(result); 
        }

        public static async ValueTask<int> MethodAsync()
        {
            await Task.Delay(3000);
            return 12;
        }
    }
}
