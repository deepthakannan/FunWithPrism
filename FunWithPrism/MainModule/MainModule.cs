using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.ServiceLocation;
using LearnPrism;

namespace MainModule
{
    public class MainModule : IModule
    {
        private IServiceLocator locator;
        public MainModule(IServiceLocator locator)
        {
            this.locator = locator;
        }

        public void Initialize()
        {
            IVideosLibrary videosLibrary = locator.GetInstance<IVideosLibrary>();
            videosLibrary.PlayVideo();
        }
    }
}
