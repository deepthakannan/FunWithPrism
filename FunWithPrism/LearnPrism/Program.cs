using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System.Configuration;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Logging;
using Microsoft.Practices.ServiceLocation;

namespace LearnPrism
{
    class Program
    {
        static void Main(string[] args)
        {
            MoviePlayerBootstrapper bootStrapper = new MoviePlayerBootstrapper();

            bootStrapper.Run();
        }
    }
}
