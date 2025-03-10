using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpsLib
{
    public class Line
    {
        protected Color color;
        public Point start;
        public Point end;
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
        public void Draw(Graphics g, Pen pen)
        {
            pen.Width = width;
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;
            g.DrawLine(pen, start, end);
        }
        public string GetParseInfo()
        {
            string output = "Line ";
            output += color.Name + " ";
            output += width + " ";
            output += start + " ";
            output += end + " ";
            return output;
        }
    }
}
