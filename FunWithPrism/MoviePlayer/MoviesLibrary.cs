using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;

namespace LearnPrism
{
    public class MoviesLibrary : IVideosLibrary
    {
        private IDiskCreator discCreator;
        private IDiskPlayer player;

        [Dependency]
        public IDiskOutput Output { get; set; }

        public MoviesLibrary(IDiskCreator discCreator, IDiskPlayer player)
        {
            this.discCreator = discCreator;
            this.player = player;
        }

        public void PlayAudio()
        {
            while (true)
            {
                IDisk disc = discCreator.Disc;
                player.PlayAudio(disc, Output);
            }                
        }

        public void PlayVideo()
        {
            while (true)
            {
                IDisk disc = discCreator.Disc;
                player.PlayVideo(disc, Output);
            }
        }
    }
}
