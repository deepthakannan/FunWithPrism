using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace Main
{
    public class SetupNewCommand : ICommand
    {
        public SetupNewCommand(MainViewModel mainViewModel)
        {
            this.mainViewModel = mainViewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            mainViewModel.LaunchNewSetupWizard();
        }

        internal MainViewModel mainViewModel { get; set; }
    }
}
