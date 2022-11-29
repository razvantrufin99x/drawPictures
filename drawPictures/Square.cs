using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace drawPictures
{
	public class Square : Shape
	{
		public float size = 100.0f;

		public float Size
		{
			get
			{
                return size;
			}
			set
			{
                size = Size;
			}
		}

		public Square(float fsize)
		{
            size = fsize;
		}

		public override void Draw(Graphics g)
		{
            g.DrawRectangle(new Pen(Color, 1), Location.X, Location.Y,size,size);

		}
	}
}
