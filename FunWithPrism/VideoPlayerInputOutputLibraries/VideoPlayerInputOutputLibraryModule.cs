﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Unity;
using LearnPrism;

namespace LearnPrism
{
    public class VideoPlayerInputOutputLibraryModule : IModule
    {
        private IUnityContainer container;
        public VideoPlayerInputOutputLibraryModule(IUnityContainer container)
        {
            this.container = container;
        }
        public void Initialize()
        {
            container.RegisterType<IDiskOutput, ConsoleDiskOutput>();
        }
    }
}
