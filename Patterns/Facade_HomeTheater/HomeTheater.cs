namespace Facade_HomeTheater
{
    public class HomeTheater
    {
        private readonly Screen _screen;
        private readonly Projector _projector;
        private readonly DVD _dvd;

        public HomeTheater(Screen screen, Projector projector, DVD dvd)
        {
            _screen = screen;
            _projector = projector;
            _dvd = dvd;
        }

        public void WatchMovie(string movie)
        {
            _screen.Down();
            _projector.On();
            _dvd.On();
            _dvd.Play(movie);
        }

        public void EndMovie()
        {
            _dvd.Stop();
            _dvd.Off();
            _projector.Off();
            _screen.Down();
        }
    }
}