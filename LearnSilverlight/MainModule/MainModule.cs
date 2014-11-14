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

namespace MainModule
{
    public class MainModule : IModule
    {
        private IUnityContainer container;
        public MainModule(IUnityContainer container)
        {
            this.container = container;
        }
        public void Initialize()
        {
            IMovieUIService movieUIService = container.Resolve<IMovieUIService>();
            Application.Current.RootVisual = movieUIService.GetMoviePlayer();
        }
    }
}
