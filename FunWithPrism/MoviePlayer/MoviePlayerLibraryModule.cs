using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Unity;
using LearnPrism;

namespace MoviePlayer
{
    public class MoviePlayerLibraryModule : IModule
    {
        private IUnityContainer container;
        public MoviePlayerLibraryModule(IUnityContainer container)
        {
            this.container = container;
        }

        public void Initialize()
        {
            container.RegisterType<IDiskCreator, MovieDiscFromConsoleCreator>();
            container.RegisterType<IDiskPlayer, LearnPrism.MoviePlayer>();
            container.RegisterType<IVideosLibrary, MoviesLibrary>();
        }
    }
}
