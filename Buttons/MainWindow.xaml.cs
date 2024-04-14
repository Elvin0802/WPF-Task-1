using System.Drawing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Buttons;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	public MainWindow()
	{
		InitializeComponent();
	}

	private void Button1_Click(object sender, RoutedEventArgs e)
	{
		((Button)sender).Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb
				((byte)Random.Shared.Next(), (byte)Random.Shared.Next(), (byte)Random.Shared.Next()));

		MessageBox.Show("Button 1 Color Changed", "Color", MessageBoxButton.OK, MessageBoxImage.Information);
	}

	private void Button2_Click(object sender, RoutedEventArgs e)
	{
		((Button)sender).Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb
			((byte)Random.Shared.Next(), (byte)Random.Shared.Next(), (byte)Random.Shared.Next()));

		MessageBox.Show("Button 2 Color Changed", "Color", MessageBoxButton.OK, MessageBoxImage.Information);
	}

	private void Button3_Click(object sender, RoutedEventArgs e)
	{
		((Button)sender).Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb
				((byte)Random.Shared.Next(), (byte)Random.Shared.Next(), (byte)Random.Shared.Next()));

		MessageBox.Show("Button 3 Color Changed", "Color", MessageBoxButton.OK, MessageBoxImage.Information);
	}

	private void Button4_Click(object sender, RoutedEventArgs e)
	{
		if (e is MouseButtonEventArgs mouse)
		{
				MessageBox.Show("Button 4 vis", "Color", MessageBoxButton.OK, MessageBoxImage.Information);
			if (mouse.RightButton == MouseButtonState.Pressed)
			{
				((Button)sender).Visibility = Visibility.Hidden;
				((Button)sender).IsEnabled = false;
				return;
			}
		}

		((Button)sender).Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb
				((byte)Random.Shared.Next(), (byte)Random.Shared.Next(), (byte)Random.Shared.Next()));

		MessageBox.Show("Button 4 Color Changed", "Color", MessageBoxButton.OK, MessageBoxImage.Information);
	}

	private void Button5_Click(object sender, RoutedEventArgs e)
	{
		((Button)sender).Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb
				((byte)Random.Shared.Next(), (byte)Random.Shared.Next(), (byte)Random.Shared.Next()));

		MessageBox.Show("Button 5 Color Changed", "Color", MessageBoxButton.OK, MessageBoxImage.Information);
	}

	private void Button6_Click(object sender, RoutedEventArgs e)
	{
		((Button)sender).Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb
				((byte)Random.Shared.Next(), (byte)Random.Shared.Next(), (byte)Random.Shared.Next()));

		MessageBox.Show("Button 6 Color Changed", "Color", MessageBoxButton.OK, MessageBoxImage.Information);
	}
}