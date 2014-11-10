using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnPrism
{
    public class MovieDisk : IDisk
    {
        public MovieDisk(string movie)
        {
            Name = movie;
            Tracks = new List<string>();
        }

        public string Name
        {
            get;
            private set;
        }

        public List<string> Tracks
        {
            get;
            private set;
        }
    }
}
