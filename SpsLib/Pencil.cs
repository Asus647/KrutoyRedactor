using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace SpsLib
{
    public class Pencil
    {
        protected Color color;
        protected int width;
        public Color Color
        {
            get { return color; }
            set { color = value; }
        }
        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        List<Point> pts = new List<Point>();
        public void AddPoint(int x, int y)
        {
            Point pt = new Point(x, y);
            pts.Add(pt);
        }
        public void Draw(Graphics g, Pen pen)
        {
            pen.Width = Width;
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;
            g.DrawLines(pen, pts.ToArray());
        }
        public string GetParseInfo()
        {
            string output = "Pencil ";
            output += color.Name + " ";
            output += width + " ";
            foreach (Point pt in pts)
            {
                output += pt + " ";
            }
            return output;
        }

    }
}
