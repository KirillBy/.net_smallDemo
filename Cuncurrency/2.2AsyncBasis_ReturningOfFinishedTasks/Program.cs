//Task: Realize synchronys method with asynchronys signature
//Usefull with module testing when stub or imitation is nessesary
//for asynchronys interface
using System;
using System.Threading;
using System.Threading.Tasks;

namespace _2._2AsyncBasis_ReturningOfFinishedTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new MySynchronousImplementation();
            var result = test.GetValueAsync();
            Console.WriteLine(result.Result);

            var result2 = test.DoSomethingAsync();
            Console.WriteLine(result2.Status);
        }
    }

    interface IMyAsyncInterface
    {
        //If Task has a returning value
        Task<int> GetValueAsync();

        //If Task has no returning value
        Task DoSomethingAsync();

        //If Task with cancellation token
        Task<int> GetValueAsync(CancellationToken cancellationToken);
    }

    class MySynchronousImplementation : IMyAsyncInterface
    {
        private void DoSomethingSynchronously()
        {
            throw new Exception();
        }

        public Task DoSomethingAsync()
        {
            //If Synchronous method not throw exception task.completedTask
            try
            {
                DoSomethingSynchronously();
                return Task.CompletedTask;
            }
            ////If Synchronous method throw exception task.fromexception
            catch(Exception ex)
            {
                return Task.FromException(ex);
            }
            
        }

        public Task<int> GetValueAsync()
        {
            return Task.FromResult(13);
        }

        public Task<int> GetValueAsync(CancellationToken cancellationToken)
        {
            if(cancellationToken.IsCancellationRequested)
            {
                return Task.FromCanceled<int>(cancellationToken);
            }

            return Task.FromResult(13);
        }
    }
}
