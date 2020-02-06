using System;
using GlobalMotocycleServiceModul;
namespace ConsolMotocycle
{
    class Program
    {
        static void Main(string[] args)
        {
            //MotoServiceDelegate @delegate = new MotoServiceDelegate(GoToService);
            MotoServiceDelegate @delegate = GoToService;
           // MotocycleService service = new MotocycleService(GoToService);
            MotocycleService service = new MotocycleService(@delegate);
            MyConsoleMotocycle motocycle = new MyConsoleMotocycle("Suzuki");

            motocycle.StartEngine();
            motocycle.Move(1000);
            motocycle.Move(5000);

            motocycle.StopEngine();
            motocycle = null;

            motocycle = new MyConsoleMotocycle("Suzuki");
            motocycle.StartEngine();
            motocycle.Move(6000);
            motocycle.StopEngine();
            motocycle = null;
            service = null;
            motocycle = new MyConsoleMotocycle("Suzuki");
            service = new MotocycleService(@delegate);
        }

        static void GoToService(int distanceFromLastService)
        {
            Console.WriteLine($"Time to go moto Service. Current distance from the last" +
                $"service is: {distanceFromLastService}");
        }
    }
}
