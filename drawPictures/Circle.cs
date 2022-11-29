using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace drawPictures
{
	public class Circle : Shape
	{
		public float radius = 100.0f;

		public float Radius
		{
			get
			{
                return radius;
			}
			set
			{
                radius = Radius;
			}
		}

		public Circle(float fradius)
		{
            radius = fradius;
		}

		public override void Draw(Graphics g)
		{
            g.DrawEllipse(new Pen(Color, 1), Location.X, Location.Y, radius, radius);
            
		}
	}
}
