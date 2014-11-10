using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnPrism
{
    public class MovieDiscFromConsoleCreator : IDiskCreator
    {
        public IDisk Disc
        {
            get 
            {
                Console.WriteLine("Movie name ?");
                MovieDisk movieDisk = new MovieDisk(Console.ReadLine());
                movieDisk.Tracks.Add("Track1");
                movieDisk.Tracks.Add("Track2");
                movieDisk.Tracks.Add("Track3");
                return movieDisk;
            }
        }
    }
}
