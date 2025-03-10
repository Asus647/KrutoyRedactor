﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SpsLib
{
    public class Rectangl : Shape {
        private int axis_a;
        private int axis_b;

        public int AxisA {
            get { return axis_a; }
            set { axis_a = value; }
        }

        public int AxisB {
            get { return axis_b; }
            set { axis_b = value; }
        }

        public Rectangl(int axis_a, int axis_b, int x, int y) : base(x, y) {
            this.axis_a = axis_a;
            this.axis_b = axis_b;
        }

        public override void Show(Graphics g, Pen pen, SolidBrush brush) {
            Rectangle rectangle = new Rectangle(center.X, center.Y, axis_a, axis_b);
            g.DrawRectangle(pen, rectangle);
            g.FillRectangle(brush, rectangle);
        }

        public override Rectangle RegionCapture() {
            return new Rectangle(center.X, center.Y, axis_a, axis_b);
        }

        public override void Resize(int x, int y, Point start) {
            if (y < start.Y) {
                center = new Point(RegionCapture().Location.X, y);
            }
            if (x < start.X) {
                center = new Point(x, RegionCapture().Location.Y);
            }

            axis_a = Math.Abs(start.X - x);
            axis_b = Math.Abs(start.Y - y);
        }
        public override void Move(int x, int y) {
            center = new Point(center.X, y);
            center = new Point(x, center.Y);
        }

        public override string GetParseInfo() {
            string output = "Rectangle ";
            output += center.X + " ";
            output += center.Y + " ";
            output += color.Name + " ";
            output += axis_a + " ";
            output += axis_b;
            return output;
        }
    }
}
