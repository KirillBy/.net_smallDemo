using System;
using System.Threading.Tasks;

namespace _2._8_AsyncBasis_ExceptionsProcedureFromAsyncTask
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await TestAsync();
            await TestAsync2();
        }

        static async Task ThrowExceptionAsync()
        {
            await Task.Delay(TimeSpan.FromSeconds(1));
            throw new InvalidOperationException("Test");
        }

        static async Task TestAsync()
        {
            try
            {
                await ThrowExceptionAsync();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex);                
            }
        }

        static async Task TestAsync2()
        {
            //Exception will be thrown first time
            Task task = ThrowExceptionAsync();
            try
            {
                //Exception will be thrown second time
                await task;
            }
            catch(InvalidOperationException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
