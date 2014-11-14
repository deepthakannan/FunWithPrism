using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Unity;
using MovieAppInterfaces;
using SilverlightMovie;

namespace SilverlightAppA
{
    public class ModuleA : IModule
    {
        private IUnityContainer container;
        public ModuleA(IUnityContainer container)
        {
            this.container = container;
        }
        public void Initialize()
        {
            container.RegisterType<IMovieService, MovieService>();
        }
    }
}
