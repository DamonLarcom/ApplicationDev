using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace Game.Objects
{
	public class GameObject
	{
		public Vector Position { get; set; }
		public Vector Velocity { get; set; }
		public Vector Size 
		{ 
			get { return new Vector(Shape.Width, Shape.Height); } 
			set { Shape.Width = value.X; Shape.Height = value.Y; }
		}
		public Rect Rect 
		{ 
			get { return new Rect((Point)(Position - (Size * 0.5)), Size); } 
		}

		public Shape Shape { get; set; }

		public virtual void Update(double dt)
		{
			Position += Velocity * dt;
		}

		public virtual void Draw()
		{
			Canvas.SetLeft(Shape, Rect.X);
			Canvas.SetTop(Shape, Rect.Y);
		}
	}
}
