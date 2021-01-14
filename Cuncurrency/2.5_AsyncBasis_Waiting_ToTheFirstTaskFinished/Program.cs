//Task: We should wait only first finished Task
//from the array of tasks
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace _2._5_AsyncBasis_Waiting_ToTheFirstTaskFinished
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        //Return the Lenght of first responded Url
        async Task<int> FirstRespondingUrlAsync(HttpClient client, string urlA, string urlB)
        {
            //Start both task parallel
            Task<byte[]> downloadTaskA = client.GetByteArrayAsync(urlA);
            Task<byte[]> downloadTaskB = client.GetByteArrayAsync(urlB);

            //Wait for completion of one of the tasks
            Task<byte[]> completedTask = await Task.WhenAny(downloadTaskA, downloadTaskB);

            //Return lenght of Urls data
            byte[] data = await completedTask;
            return data.Length;
        }
    }
}
