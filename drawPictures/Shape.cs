using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace drawPictures
{
	public abstract class Shape : IDrawable
	{
		public Color color = new Color();
		public PointF location = new PointF(100,100);

		public Color Color
		{
			get
			{
                return color;
			}
			set
			{
                color = Color;
			}
		}

		public PointF Location
		{
			get
			{
                return location;
			}
			set
			{
                location = Location;
			}
		}

		protected Shape()
		{
            color = Color.Black;
		}

		public abstract void Draw(Graphics g);
	}
}
