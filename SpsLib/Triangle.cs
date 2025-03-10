using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpsLib
{
    public class Triangle : Shape
    {
        private int axis_a;
        private int axis_b;
        private bool dn = false;
        private bool up = false;
        public bool DN
        {
            get { return dn; }
            set { dn = value; }
        }
        public bool UP
        {
            get { return up; }
            set { up = value; }
        }
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

        public Triangle(int axis_a, int axis_b, int x, int y) : base(x, y)
        {
            this.axis_a = axis_a;
            this.axis_b = axis_b;
        }

        public override void Show(Graphics g, Pen pen, SolidBrush brush)
        {
            List<Point> pts = new List<Point>();
            Point pt1 = new Point();
            Point pt2 = new Point();
            Point pt3 = new Point();
            if (up)
            {
                pt1 = new Point(center.X, center.Y + axis_b);
                pt2 = new Point(center.X + axis_a / 2, center.Y);
                pt3 = new Point(center.X + axis_a, center.Y + axis_b);
            }
            else if (dn)
            {
                pt1 = new Point(center.X, center.Y);
                pt2 = new Point(center.X + axis_a / 2, center.Y + axis_b);
                pt3 = new Point(center.X + axis_a, center.Y);
            }
            pts.Add(pt1);
            pts.Add(pt2);
            pts.Add(pt3);
            g.DrawPolygon(pen, pts.ToArray());
            g.FillPolygon(brush, pts.ToArray());
        }

        public override Rectangle RegionCapture()
        {
            return new Rectangle(center.X, center.Y, axis_a, axis_b);
        }

        public override void Resize(int x, int y, Point start)
        {
            if (y > start.Y)
            {
                dn = true;
                up = false;
            }
            else if (y < start.Y)
            {
                up = true;
                dn = false;
            }
            if (y < start.Y)
            {
                center = new Point(RegionCapture().Location.X, y);
            }
            if (x < start.X)
            {
                center = new Point(x, RegionCapture().Location.Y);
            }

            axis_a = Math.Abs(x - start.X);
            axis_b = Math.Abs(y - start.Y);
        }

        public override void Move(int x, int y)
        {
            center = new Point(center.X, y);
            center = new Point(x, center.Y);
        }

        public override string GetParseInfo()
        {
            string output = "Triangle ";
            output += center.X + " ";
            output += center.Y + " ";
            output += color.Name + " ";
            output += axis_a + " ";
            output += axis_b + " ";
            output += dn + " ";
            output += up;
            return output;
        }
    }
}
