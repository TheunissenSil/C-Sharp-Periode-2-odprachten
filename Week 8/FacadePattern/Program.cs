namespace FacadePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Amplifier amp = new Amplifier();
            CdPlayer cdPlayer = new CdPlayer(amp);
            DvdPlayer dvdPlayer = new DvdPlayer(amp);
            PopcornPopper popcornPopper = new PopcornPopper();
            Projector projector = new Projector();
            Screen screen = new Screen();
            TheaterLights lights = new TheaterLights();
            Tuner tuner = new Tuner(amp);

            // Create the HomeTheaterFacade instance
            HomeTheaterFacade homeTheater = new HomeTheaterFacade(amp, cdPlayer, dvdPlayer, popcornPopper, projector, screen, lights, tuner);

            // Start watching a movie
            homeTheater.WatchMovie("Die Hard");

            // End the movie
            homeTheater.EndMovie();
        }
    }
}
