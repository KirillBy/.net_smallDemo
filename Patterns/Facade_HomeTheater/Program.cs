using System;

namespace Facade_HomeTheater
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeTheater homeTheater = new HomeTheater(new Screen(), new Projector(), new DVD());
            homeTheater.WatchMovie("American Pie 7");
            homeTheater.EndMovie();
        }
    }
}
