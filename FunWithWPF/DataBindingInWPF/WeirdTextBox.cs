using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace DataBindingInWPF
{
	public class WeirdTextBox : TextBox
	{
		public WeirdTextBox()
		{
			this.TextChanged += WeirdTextBox_TextChanged;
		}

		void WeirdTextBox_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (ActWeird)
			{
				this.Background = this.Background == Brushes.White ? Brushes.Tomato : Brushes.White;
			}
			else
				this.Background = Brushes.White;
		}
		public static DependencyProperty ActWeirdProperty = DependencyProperty.Register("ActWeird", typeof(bool), typeof(WeirdTextBox), new FrameworkPropertyMetadata(new PropertyChangedCallback(PropertyChangedCallback)), null);

		[System.ComponentModel.Description("ActWeird")]
		[System.ComponentModel.Category("ActWeird Category")]
		[System.ComponentModel.Browsable(true)]
		[System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Visible)]
		public bool ActWeird
		{
			get
			{
				return ((bool)(base.GetValue(WeirdTextBox.ActWeirdProperty)));
			}
			set
			{
				base.SetValue(WeirdTextBox.ActWeirdProperty, value);
			}
		}

		public static void PropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
		}
	}
}
