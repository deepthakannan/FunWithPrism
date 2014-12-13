using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataBindingInWPF
{
	class FullContext
	{
		public List<KeyValuePair<string, string>> Items { get; set; }
	}
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			this.DataContext = new FullContext() { Items = new List<KeyValuePair<string, string>>() { new KeyValuePair<string, string>("Deeptha", "Kannan"), new KeyValuePair<string, string>("Deeptha13424", "Kannan234242") } };
			textBox1.DataContext = new TabControl() { TabStripPlacement = Dock.Right };
		}
	}
}
