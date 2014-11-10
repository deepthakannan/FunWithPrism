using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System.Configuration;

namespace LearnPrism
{
    class Program
    {
        static void Main(string[] args)
        {
            UnityContainer container = new UnityContainer();

            UnityConfigurationSection configurationSection = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");

            configurationSection.Containers.Default.Configure(container);

            IVideosLibrary videoLibrary = container.Resolve<IVideosLibrary>();
            videoLibrary.PlayVideo();
        }
    }
}
