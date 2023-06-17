﻿using Facade.Facade;
using Facade.Subsystems;

namespace Facade
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var amp = new Amplifier("Top-O-Line Amplifier");
            var tuner = new Tuner("Top-O-Line AM/FM Tuner", amp);
            var dvd = new DvdPlayer("Top-O-Line DVD Player", amp);
            var cd = new CdPlayer("Top-O-Line CD Player", amp);
            var projector = new Projector("Top-O-Line Projector", dvd);
            var lights = new TheaterLights("Theater Ceiling Lights");
            var screen = new Screen("Theater Screen");
            var popper = new PopcornPopper("Popcorn Popper");

            var homeTheater = new HomeTheater(amp, tuner, dvd, cd, projector, screen, lights, popper);

            homeTheater.WatchMovie("Raiders of the Lost Ark");
            homeTheater.EndMovie();
        }
    }
}
