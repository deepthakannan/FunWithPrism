using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.UnityExtensions;
using Microsoft.Practices.Prism.Modularity;

namespace LearnPrism
{
    public class MoviePlayerBootstrapper : UnityBootstrapper
    {
        protected override System.Windows.DependencyObject CreateShell()
        {
            return null;
        }

        protected override IModuleCatalog  CreateModuleCatalog()
        {
            return new ConfigurationModuleCatalog();
        }
    }
}
