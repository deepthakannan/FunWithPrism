using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnPrism
{
    public class ConsoleDiskOutput : IDiskOutput
    {
        public void Write(string data)
        {
            Console.WriteLine(data);
        }
    }
}
