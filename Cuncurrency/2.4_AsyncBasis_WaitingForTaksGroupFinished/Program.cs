//Task: Need to wait untill all tasks finished

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace _2._4_AsyncBasis_WaitingForTaksGroupFinished
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Task task1 = Task.Delay(TimeSpan.FromSeconds(1));
            Task task2 = Task.Delay(TimeSpan.FromSeconds(2));
            Task task3 = Task.Delay(TimeSpan.FromSeconds(1));

            await Task.WhenAll(task1, task2, task3);

            Task<int> task4 = Task.FromResult(3);
            Task<int> task5 = Task.FromResult(5);
            Task<int> task6 = Task.FromResult(6);

            //Result will contain array with all tasks results    
            var result = Task.WhenAll(task4, task5, task6);
            Console.WriteLine(result.Result[0] + result.Result[1] + result.Result[2]);
        }

        //When all has which get an IEnumerable as a parameter, but better not to use it
        async Task<string> DownloadAllAsync(HttpClient client, IEnumerable<string> urls)
        {
            //downloads here - IEnumerable
            var downloads = urls.Select(url => client.GetStringAsync(url));

            //better to materialize it to array
            Task<string>[] downloadTasks = downloads.ToArray();

            string[] htmlPages = await Task.WhenAll(downloadTasks);

            return string.Concat(htmlPages);
        }
    }
}
