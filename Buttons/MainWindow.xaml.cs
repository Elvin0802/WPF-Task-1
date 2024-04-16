using System.Drawing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Buttons;

public partial class MainWindow : Window
{
	public MainWindow()
	{
		InitializeComponent();
	}

	private void Button_MouseDown(object sender, MouseButtonEventArgs e)
	{
		var btn = (Button)sender;

		btn.Visibility = Visibility.Hidden;
	}

	private void Button_Click(object sender, RoutedEventArgs e)
	{
		var btn = (Button)sender;

		btn.Background =
		new SolidColorBrush(System.Windows.Media.Color.
			FromRgb((byte)Random.Shared.Next(0, 255), (byte)Random.Shared.Next(0, 255), (byte)Random.Shared.Next(0, 255)));

		MessageBox.Show($"Button {btn.Content} Color Changed", "Color", MessageBoxButton.OK, MessageBoxImage.Information);

		Button1.Visibility = Visibility.Visible;
	}
}