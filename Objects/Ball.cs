using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Game.Objects
{
	class Ball : GameObject
	{
		public Ball(Vector position, Vector velocity, Vector size)
		{
			Shape = new Rectangle();
			Shape.Fill = new SolidColorBrush(Colors.White);
			Position = position;
			Velocity = velocity;
			Size = size;
		}

		public override void Update(double dt)
		{
			// ball code

			base.Update(dt);
		}
	}
}
