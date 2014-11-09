using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnPrism
{
    class Program
    {
        static void Main(string[] args)
        {
            IDiskOutput display = new ConsoleDiskOutput();
            IDiskCreator diskCreator = new MovieDiscFromConsoleCreator();
            IDiskPlayer player = new MoviePlayer();
            IDisk disc = diskCreator.Disc;
            player.PlayAudio(disc, display);
            player.PlayVideo(disc, display);
        }
    }
}
