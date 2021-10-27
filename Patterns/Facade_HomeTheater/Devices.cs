using System;

namespace Facade_HomeTheater
{
    public class Screen
    {
        public void Down()
        {
            Console.WriteLine("Screen is down");
        }
        
        public void Up()
        {
            Console.WriteLine("Screen is up");
        }
    }

    public class Projector
    {
        public void On()
        {
            Console.WriteLine("Projector is On");
        }
        
        public void Off()
        {
            Console.WriteLine("Projector is Off");
        }
    }

    public class DVD
    {
        public void On()
        {
            Console.WriteLine("DVD is On");
        }
        
        public void Off()
        {
            Console.WriteLine("DVD is Off");
        }
        
        public void Stop()
        {
            Console.WriteLine("DVD is stopped");
        }
        
        public void Play(string movie)
        {
            Console.WriteLine($"{movie} is playing now...");
        }
    }
}