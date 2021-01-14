using System;
using System.Threading.Tasks;

namespace _2._7_AsyncBasis_ConfigureAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        async Task ResumeOnContextAsync()
        {
            //This method will return in the same context
            await Task.Delay(TimeSpan.FromSeconds(1));
        }

        async Task ResumeWithoutContextAsync()
        {
            //This method will losse context after returning
            await Task.Delay(TimeSpan.FromSeconds(1)).ConfigureAwait(false);
        }
    }
}
