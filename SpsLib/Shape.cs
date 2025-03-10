using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SpsLib
{
    /// <summary>
    /// абстрактный класс родитель для всех фигур
    /// </summary>
    public abstract class Shape
    {
        protected Point center;
        protected Color color;


        public Point Center{
            get { return center; }
            set { center = value; }
        }

        public Color Color
        {
            get { return color; }
            set { color = value; }
        }

        public Shape(int x, int y)
        {
            center = new Point(x, y);
            color = Color.Black;
        }

        public abstract void Move(int x, int y);
       

        public abstract void Show(Graphics g, Pen pen, SolidBrush brush);

        public abstract Rectangle RegionCapture();

        public abstract void Resize(int x, int y, Point start);

        public static bool IsInRectangle(int x, int y, Rectangle rect) {
            if(x >= rect.Left && x <= rect.Right && y >= rect.Top && y <= rect.Bottom) {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Абстрактный метод для получения полной информации о фигуре в текстовом формате
        /// </summary>
        /// <returns></returns>
        public abstract string GetParseInfo();
    }
}
