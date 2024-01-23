namespace FacadePattern
{
    internal class HomeTheaterFacade
    {
        private Amplifier _amp;
        private CdPlayer _cdPlayer;
        private DvdPlayer _dvdPlayer;
        private PopcornPopper _popcornPopper;
        private Projector _projector;
        private Screen _screen;
        private TheaterLights _lights;
        private Tuner _tuner;

        public HomeTheaterFacade(
            Amplifier amp,
            CdPlayer cdPlayer,
            DvdPlayer dvdPlayer,
            PopcornPopper popcornPopper,
            Projector projector,
            Screen screen,
            TheaterLights lights,
            Tuner tuner)
        {
            _amp = amp;
            _cdPlayer = cdPlayer;
            _dvdPlayer = dvdPlayer;
            _popcornPopper = popcornPopper;
            _projector = projector;
            _screen = screen;
            _lights = lights;
            _tuner = tuner;
        }

        // Implement the WatchMovie method
        public void WatchMovie(string movie)
        {
            Console.WriteLine($"Get ready to watch a movie: {movie}");
            _popcornPopper.On();
            _popcornPopper.Pop();
            _lights.Dim(10);
            _screen.Down();
            _projector.On();
            _projector.SetInput(_dvdPlayer);
            _projector.WideScreenMode();
            _amp.On();
            _amp.SetDvd(_dvdPlayer);
            _amp.SetSurroundSound();
            _amp.SetVolume(5);
            _dvdPlayer.On();
            _dvdPlayer.Play(movie);
        }

        // Implement the EndMovie method
        public void EndMovie()
        {
            Console.WriteLine("Shutting down the movie theater");
            _popcornPopper.Off();
            _lights.On();
            _screen.Up();
            _projector.Off();
            _amp.Off();
            _dvdPlayer.Stop();
            _dvdPlayer.Eject();
            _dvdPlayer.Off();
        }
    }
}
