using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnPrism
{
    public interface IVideosLibrary
    {
        void PlayAudio();
        void PlayVideo();
        IDiskOutput Output { get; set; }
    }
}
