using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnPrism
{
    public interface IDiskPlayer
    {
        void PlayAudio(IDisk disk, IDiskOutput output);
        void PlayVideo(IDisk disk, IDiskOutput output);
    }
}
