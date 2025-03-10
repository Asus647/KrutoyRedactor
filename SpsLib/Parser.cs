using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using static System.Windows.Forms.LinkLabel;
using System.Reflection;
using System.Text.RegularExpressions;

namespace SpsLib
{
    public class Parser
    {

        public void CreateParseInfo(ref HashSet<Shape> shapes, ref HashSet<Pencil> pencils, ref HashSet<Line> lines, string path) {
            StreamWriter writer = new StreamWriter(path);
            foreach(Shape shape in shapes) {
                writer.WriteLine(shape.GetParseInfo());
            }
            if (!pencils.Contains(null))
            {
                foreach (Pencil pen in pencils)
                {
                    writer.WriteLine(pen.GetParseInfo());
                }
            }
            if (!lines.Contains(null))
            {
                foreach (Line line in lines)
                {
                    writer.WriteLine(line.GetParseInfo());
                }
            }
            writer.Flush();
            writer.Close();
        }

        public HashSet<Shape> ParseFuncObjects(string path) {
            HashSet<Shape> shapes = new HashSet<Shape>();
            StreamReader reader = new StreamReader(path);
            while (true) {
                string temp = reader.ReadLine();
                if(temp == null) {
                    break;
                }
                string[] data = temp.Split(' ');
                if (data[0] == "Ellipse") {
                    shapes.Add(ParseEllipse(data));
                }else if(data[0] == "Rectangle") {
                    shapes.Add(ParseRectangle(data));
                }else if (data[0] == "Circle")
                {
                    shapes.Add(ParseCircle(data));
                }
                else if (data[0] == "Square")
                {
                    shapes.Add(ParseSquare(data));
                }
                else if (data[0] == "RightTriangle")
                {
                    shapes.Add(ParseRightTriangle(data));
                }
                else if (data[0] == "Triangle")
                {
                    shapes.Add(ParseTriangle(data));
                }
                else if (data[0] == "Star")
                {
                    shapes.Add(ParseStar(data));
                }
            }
            return shapes;
        }
        public HashSet<Pencil> ParseFuncObjectsPens(string path)
        {
            HashSet<Pencil> pencils = new HashSet<Pencil>();
            StreamReader reader = new StreamReader(path);
            while (true)
            {
                string temp = reader.ReadLine();
                if (temp == null)
                {
                    break;
                }
                string[] data = temp.Split(' ');
                if (data[0] == "Pencil")
                {
                    pencils.Add(ParsePencil(data));
                }
            }
            return pencils;
        }
        public HashSet<Line> ParseFuncObjectsLines(string path)
        {
            HashSet<Line> lines = new HashSet<Line>();
            StreamReader reader = new StreamReader(path);
            while (true)
            {
                string temp = reader.ReadLine();
                if (temp == null)
                {
                    break;
                }
                string[] data = temp.Split(' ');
                if (data[0] == "Line")
                {
                    lines.Add(ParseLine(data));
                }
            }
            return lines;
        }

        private Ellipse ParseEllipse(string[] data) {
            Ellipse ellipse = new Ellipse(int.Parse(data[4]), int.Parse(data[5]), int.Parse(data[1]), int.Parse(data[2]));
            ellipse.Color = Color.FromName(data[3]);
            return ellipse;
        }
        private Rectangl ParseRectangle(string[] data) {
            Rectangl rect = new Rectangl(int.Parse(data[4]), int.Parse(data[5]), int.Parse(data[1]), int.Parse(data[2]));
            rect.Color = Color.FromName(data[3]);
            return rect;
        }
        private Circle ParseCircle(string[] data)
        {
            Circle circle = new Circle(int.Parse(data[4]), int.Parse(data[5]), int.Parse(data[1]), int.Parse(data[2]));
            circle.Color = Color.FromName(data[3]);
            return circle;
        }
        private Square ParseSquare(string[] data)
        {
            Square square = new Square(int.Parse(data[4]), int.Parse(data[5]), int.Parse(data[1]), int.Parse(data[2]));
            square.Color = Color.FromName(data[3]);
            return square;
        }
        private Star ParseStar(string[] data)
        {
            Star star = new Star(int.Parse(data[4]), int.Parse(data[5]), int.Parse(data[1]), int.Parse(data[2]));
            star.Color = Color.FromName(data[3]);
            return star;
        }
        private Triangle ParseTriangle(string[] data)
        {
            Triangle triangle = new Triangle(int.Parse(data[4]), int.Parse(data[5]), int.Parse(data[1]), int.Parse(data[2]));
            triangle.Color = Color.FromName(data[3]);
            triangle.DN = bool.Parse(data[6]);
            triangle.UP = bool.Parse(data[7]);
            return triangle;
        }
        private RightTriangle ParseRightTriangle(string[] data)
        {
            RightTriangle rightTriangle = new RightTriangle(int.Parse(data[4]), int.Parse(data[5]), int.Parse(data[1]), int.Parse(data[2]));
            rightTriangle.Color = Color.FromName(data[3]);
            rightTriangle.LUC = bool.Parse(data[6]);
            rightTriangle.LDC = bool.Parse(data[7]);
            rightTriangle.RDC = bool.Parse(data[8]);
            return rightTriangle;
        }
        private Pencil ParsePencil(string[] data)
        {
            Pencil pencil = new Pencil();
            pencil.Color = Color.FromName(data[1]);
            pencil.Width = int.Parse(data[2]);
            Regex regex = new Regex(@"\{X=(\d+),Y=(\d+)\}");
            foreach (string datas in data)
            {
                MatchCollection matches = regex.Matches(datas);

                foreach (Match match in matches)
                {
                    int x = int.Parse(match.Groups[1].Value);
                    int y = int.Parse(match.Groups[2].Value);

                    pencil.AddPoint(x,y);
                }
            }
            return pencil;
        }
        private Line ParseLine(string[] data)
        {
            Line line = new Line();
            line.Color = Color.FromName(data[1]);
            line.Width = int.Parse(data[2]);
            List<Point> pt = new List<Point>(2);
            Regex regex = new Regex(@"\{X=(\d+),Y=(\d+)\}");
            foreach (string datas in data)
            {
                MatchCollection matches = regex.Matches(datas);

                foreach (Match match in matches)
                {
                    int x = int.Parse(match.Groups[1].Value);
                    int y = int.Parse(match.Groups[2].Value);

                    pt.Add(new Point(x, y));
                }
            }
            Point[] pts = pt.ToArray(); 
            line.start = pts[0];
            line.end = pts[1];
            return line;
        }
    }
}
