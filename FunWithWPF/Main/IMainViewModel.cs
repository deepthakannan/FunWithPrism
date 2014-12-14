using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Main
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            InitializeCommands();
        }

        private void InitializeCommands()
        {
            LaunchNewSetupWizardCommmand = new SetupNewCommand(this);
        }
        internal void LaunchNewSetupWizard()
        {
            SetupNewWizard wizard = new SetupNewWizard();
            wizard.Show();
        }

        public SetupNewCommand LaunchNewSetupWizardCommmand { get; set; }
    }
}
