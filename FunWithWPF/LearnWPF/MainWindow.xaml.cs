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
            AddAButtonToDockPanelAndSetItsDockUsingAttachedProperties();
            AddLoginTypeRadioButtons();

        }

        private void AddLoginTypeRadioButtons()
        {
            StackPanel loginTypeStakePPanel = new StackPanel() { Orientation = System.Windows.Controls.Orientation.Horizontal, HorizontalAlignment=System.Windows.HorizontalAlignment.Center };
            loginTypeStakePPanel.Children.Add(new RadioButton() { Content = "Windows" });
            loginTypeStakePPanel.Children.Add(new RadioButton() { Content = "SQL" });
            loginStackPanel.Children.Add(loginTypeStakePPanel);
        }

        private void AddAButtonToDockPanelAndSetItsDockUsingAttachedProperties()
        {
            Button button = new Button() { Content = "Close" };
            dockPanel.Children.Add(button);
            DockPanel.SetDock(button, Dock.Right);
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

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            new TicTacToe().Show();
        }
    }
}
