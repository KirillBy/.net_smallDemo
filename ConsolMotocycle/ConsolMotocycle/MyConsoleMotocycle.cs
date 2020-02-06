using System;
using System.Collections.Generic;
using System.Text;
using GlobalMotocycleServiceModul;

namespace ConsolMotocycle
{
    class MyConsoleMotocycle
    {
        public string Model { get;  set; }
        public DateTime Year { get; set; }
        public int DailyDistance { get; private set; }
        public static int Odometr { get; private set; }
        public MyConsoleMotocycle(string model )
        {
            Model = model;
        }

        public void StartEngine()
        {
            Console.WriteLine();
            Console.WriteLine($"Engine has been started at {DateTime.Now}");
        }

        public void Move(int distance)
        {
            DailyDistance += distance;
            Console.WriteLine($"Move to {distance}");
        }
        public void StopEngine()
        {
            Odometr += DailyDistance;
            //Call Service
            MotocycleService.DistanceFromService += DailyDistance;
            Console.WriteLine($"Engine has been stoped at {DateTime.Now}");
            Console.WriteLine($"Total distance {Odometr} km");
        }
    }
}
