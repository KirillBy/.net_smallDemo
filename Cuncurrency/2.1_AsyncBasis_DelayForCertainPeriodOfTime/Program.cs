//Task: needs to be stoped application execution for some period of
//time. Helpfull for module testing or realization of simple time-out
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace _2._1_AsyncBasis_DelayForCertainPeriodOfTime
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var result = await DelayResult<int>(5, TimeSpan.FromSeconds(2));
            Console.WriteLine(result);
        }
        
        //Return task for asyncronious success
        static async Task<T> DelayResult<T> (T result, TimeSpan delay)
        {
            await Task.Delay(delay);
            return result;
        }

        //Exponential delay
        static async  Task<string> DownloadStringWithRetries(HttpClient client, string uri)
        {
            //Try to load string after 1 sec, than 2 sec, than 4 sec
            TimeSpan nextDelay = TimeSpan.FromSeconds(1);
            for(int i = 0; i != 3; ++i)
            {
                try
                {
                    return await client.GetStringAsync(uri);
                }
                catch
                {
                }

                await Task.Delay(nextDelay);
                nextDelay = nextDelay + nextDelay;
            }

            // Try final time and grand exception spread
            return await client.GetStringAsync(uri);
        }
    }
}
