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
using MovieAppInterfaces;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Unity;
using SilverlightMovie;

namespace SilverlightAppB
{
    public class ModuleB : IModule
    {
        private IUnityContainer container;
        public ModuleB(IUnityContainer container)
        {
            this.container = container;
        }
        public void Initialize()
        {
            container.RegisterType<IMovieUIService, MovieUIService>();
        }
    }
}
