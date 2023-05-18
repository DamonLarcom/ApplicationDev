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
using System.Windows.Threading;
using Game.Objects;

namespace Game
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		DispatcherTimer timer = new DispatcherTimer();
		DateTime prevTime = new DateTime();
		Ball ball;

		public MainWindow()
		{
			InitializeComponent();

			prevTime = DateTime.Now;
			timer.Tick += Timer_Tick;
			timer.Start();
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			ball = new Ball(new Vector(150, 150), new Vector(10, 10), new Vector(30, 30));

			cnvGame.Children.Add(ball.Shape);
		}

		void Timer_Tick(object sender, EventArgs e)
		{
			TimeSpan timeSpan = DateTime.Now - prevTime;
			prevTime = DateTime.Now;

			double dt = timeSpan.TotalSeconds;

			ball.Update(dt);
			ball.Draw();
		}


	}
}
