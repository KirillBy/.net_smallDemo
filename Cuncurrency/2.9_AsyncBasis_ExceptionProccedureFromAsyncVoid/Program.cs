//Task: to proccedure exception from async method which return void

using System;
using System.Threading.Tasks;
using Nito.AsyncEx;

namespace _2._9_AsyncBasis_ExceptionProccedureFromAsyncVoid
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // From library Nito.AsyncEx
                AsyncContext.Run(()=> MainAsync(args));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        static async void MainAsync(string[] args)
        {
            await Task.Delay(TimeSpan.FromSeconds(2));
            Console.WriteLine("There is a logic of MainAsync ");
            throw new Exception("Exception from MainAsync");
        }
    }
}
