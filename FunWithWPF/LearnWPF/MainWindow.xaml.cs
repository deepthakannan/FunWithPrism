using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LearnWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MakePatrioticGridBackGround();
        }

        private void MakePatrioticGridBackGround()
        {
            grid.Background = new LinearGradientBrush() 
            { 
                GradientStops = new GradientStopCollection() 
                { 
                    new GradientStop(Colors.Orange, 0.33), 
                    new GradientStop(Colors.White, 0.67), 
                    new GradientStop(Colors.Green, 1) 
                } 
            };
        }

        private void HowILearnBuuttonButtonClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Youtube");
        }
    }
}
