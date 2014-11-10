using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnPrism
{
    public interface IDisk
    {
        string Name { get; }
        List<string> Tracks { get; }
    }
}
