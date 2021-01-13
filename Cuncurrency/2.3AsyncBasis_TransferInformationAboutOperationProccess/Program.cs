//Task: need to react to operation progress
using System;
using System.Threading.Tasks;

namespace _2._3AsyncBasis_TransferInformationAboutOperationProccess
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await CallMyMethodAsync();
        }

        static async Task MyMethodAsync(IProgress<double> progress = null)
        {
            bool done = false;
            double percentComplete = 0;
            while(!done)
            {
                if(percentComplete == 10)
                {
                    done = true;
                }
                percentComplete++;
                await Task.Delay(TimeSpan.FromSeconds(1));
                progress?.Report(percentComplete);
            }
        }

        static async Task CallMyMethodAsync()
        {
            var progress = new Progress<double>();
            progress.ProgressChanged += (sender, args) => 
            {
                Console.WriteLine(args.ToString());
            };
            
            await MyMethodAsync(progress);
        }
    }
}
