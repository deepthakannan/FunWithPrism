using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnPrism
{
    public class MoviePlayer : IDiskPlayer
    {
        public void PlayAudio(IDisk disk, IDiskOutput output)
        {
            output.Write("Playing audio of movie : " + disk.Name);
            foreach (string track in disk.Tracks)
            {
                output.Write(track);
            }
        }

        public void PlayVideo(IDisk disk, IDiskOutput output)
        {
            output.Write("Playing video of movie : " + disk.Name);
            foreach (string track in disk.Tracks)
            {
                output.Write(track);
            }
            output.Write("The end !!!");
        }
    }
}
