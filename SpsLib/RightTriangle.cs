using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpsLib
{
    public class RightTriangle : Shape
    {
        private int axis_a;
        private int axis_b;
        private bool luc = false;
        private bool ldc = false;
        private bool rdc = false;
        public bool LUC
        {
            get { return luc; }
            set { luc = value; }
        }
        public bool LDC
        {
            get { return ldc; }
            set { ldc = value; }
        }
        public bool RDC
        {
            get { return rdc; }
            set { rdc = value; }
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

        public RightTriangle(int axis_a, int axis_b, int x, int y) : base(x, y)
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
            if (luc)
            {
                pt1 = new Point(center.X + axis_a, center.Y);
                pt2 = new Point(center.X + axis_a, center.Y + axis_b);
                pt3 = new Point(center.X, center.Y);
            }
            else if (ldc)
            {
                pt1 = new Point(center.X + axis_a, center.Y);
                pt2 = new Point(center.X, center.Y + axis_b);
                pt3 = new Point(center.X + axis_a, center.Y + axis_b);
            }
            else if (rdc)
            {
                pt1 = new Point(center.X, center.Y);
                pt2 = new Point(center.X, center.Y + axis_b);
                pt3 = new Point(center.X + axis_a, center.Y + axis_b);
            }
            else
            {
                pt1 = new Point(center.X, center.Y + axis_b);
                pt2 = new Point(center.X, center.Y);
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
            if (y < start.Y && x < start.X)
            {
                rdc = false;
                ldc = false;
                luc = true;
            }
            else if (x < start.X && y > start.Y)
            {
                ldc = true;
                luc = false;
                rdc = false;
            }
            else if (x > start.X && y < start.Y)
            {
                rdc = false;
                luc = false;
                ldc = false;
            }
            else if (x > start.X && y > start.Y)
            {
                luc = false;
                ldc = false;
                rdc = true;
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
            string output = "RightTriangle ";
            output += center.X + " ";
            output += center.Y + " ";
            output += color.Name + " ";
            output += axis_a + " ";
            output += axis_b + " ";
            output += luc + " ";
            output += ldc + " ";
            output += rdc;
            return output;
        }
    }
}
