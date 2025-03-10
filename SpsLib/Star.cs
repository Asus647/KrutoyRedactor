using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpsLib
{
    public class Star : Shape
    {
        private int axis_a;
        private int axis_b;
        private double da = Math.PI / 5;
        private double a = Math.PI / 2;
        private double l;

        public int AxisA
        {
            get { return axis_a; }
            set { axis_a = value; }
        }

        public int AxisB
        {
            get { return axis_b; }
            set { axis_b = value; }
        }

        public Star(int axis_a, int axis_b, int x, int y) : base(x, y)
        {
            this.axis_a = axis_a;
            this.axis_b = axis_b;
        }

        public override void Show(Graphics g, Pen pen, SolidBrush brush)
        {
            List<PointF> pts = new List<PointF>();
            for (int i = 0; i < 2 * 5 + 1; i++)
            {
                l = i % 2 == 0 ? axis_a : axis_b;
                PointF pt = new PointF((float)((center.X + axis_a / 2) + l * Math.Cos(a)), (float)((center.Y + axis_b / 2) + l * Math.Sin(a)));
                pts.Add(pt);
                a += da;
            }
            g.DrawPolygon(pen, pts.ToArray());
            g.FillPolygon(brush, pts.ToArray());
            a = 0;
        }

        public override Rectangle RegionCapture()
        {
            return new Rectangle(center.X, center.Y, axis_a, axis_b);
        }

        public override void Resize(int x, int y, Point start)
        {
            if (y < start.Y)
            {
                center = new Point(RegionCapture().Location.X, y);
            }
            if (x < start.X)
            {
                center = new Point(x, RegionCapture().Location.Y);
            }

            axis_a = Math.Abs(start.X - x);
            axis_b = axis_a * 2;
        }
        public override void Move(int x, int y)
        {
            center = new Point(center.X, y);
            center = new Point(x, center.Y);
        }

        public override string GetParseInfo()
        {
            string output = "Star ";
            output += center.X + " ";
            output += center.Y + " ";
            output += color.Name + " ";
            output += axis_a + " ";
            output += axis_b;
            return output;
        }
    }
}
