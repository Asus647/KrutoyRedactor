using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using SpsLib;

namespace graphHuyaph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        HashSet<Shape> shapes = new HashSet<Shape>();
        Shape cur_shape;
        HashSet<Pencil> pencils = new HashSet<Pencil>();
        Pencil cur_pencil;
        HashSet<Line> lines = new HashSet<Line>();
        Line cur_line;
        Point start;
        string cur_mode = "edit";
        string color = "red";
        int width = 10;

        /// <summary>
        /// Метод для выбора фигуры с холста
        /// </summary>
        /// <param name="e"></param>
        private void ChooseShape(MouseEventArgs e)
        {
            double minimum = 1000000;
            foreach (Shape current in shapes)
            {
                double distance = Math.Pow(current.Center.X - e.X, 2) + Math.Pow(current.Center.Y - e.Y, 2);
                if (distance < minimum && Shape.IsInRectangle(e.X, e.Y, current.RegionCapture()))
                {
                    cur_shape = current;
                    minimum = distance;
                    if (cur_mode == "editSize")
                    {
                        start = cur_shape.Center;
                    }
                }
            }
        }
        /// <summary>
        /// События, происходящие при нажатии ЛКМ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void draw_panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            if ((cur_mode == "edit" || cur_mode == "editSize") && shapes.Count > 0)
            {
                ChooseShape(e);
            }
            else if (cur_mode == "ell")
            {
                start = e.Location;
                cur_shape = new Ellipse(0, 0, start.X, start.Y);
                cur_shape.Color = Color.FromName(color);
                shapes.Add(cur_shape);
            }
            else if (cur_mode == "rect")
            {
                start = e.Location;
                cur_shape = new Rectangl(0, 0, start.X, start.Y);
                cur_shape.Color = Color.FromName(color);
                shapes.Add(cur_shape);
            }
            else if (cur_mode == "crc")
            {
                start = e.Location;
                cur_shape = new Circle(0, 0, start.X, start.Y);
                cur_shape.Color = Color.FromName(color);
                shapes.Add(cur_shape);
            }
            else if (cur_mode == "sqr")
            {
                start = e.Location;
                cur_shape = new Square(0, 0, start.X, start.Y);
                cur_shape.Color = Color.FromName(color);
                shapes.Add(cur_shape);
            }
            else if (cur_mode == "rtrg")
            {
                start = e.Location;
                cur_shape = new RightTriangle(0, 0, start.X, start.Y);
                cur_shape.Color = Color.FromName(color);
                shapes.Add(cur_shape);
            }
            else if (cur_mode == "trg")
            {
                start = e.Location;
                cur_shape = new Triangle(0, 0, start.X, start.Y);
                cur_shape.Color = Color.FromName(color);
                shapes.Add(cur_shape);
            }
            else if (cur_mode == "str")
            {
                start = e.Location;
                cur_shape = new Star(0, 0, start.X, start.Y);
                cur_shape.Color = Color.FromName(color);
                shapes.Add(cur_shape);
            }
            else if (cur_mode == "pen")
            {
                cur_pencil = new Pencil();
                cur_pencil.Width = width;
                cur_pencil.Color = Color.FromName(color);
                cur_pencil.AddPoint(e.X, e.Y);
            }
            else if (cur_mode == "line")
            {
                cur_line = new Line();
                cur_line.Width = width;
                cur_line.Color = Color.FromName(color);
                cur_line.start = e.Location;
            }
        }
        /// <summary>
        /// События, происходящие при передвижении мышки с зажатой ЛКМ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void draw_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            switch (cur_mode)
            {
                case "edit":
                    if (cur_shape != null)
                    {
                        cur_shape.Move(e.X, e.Y);
                    }
                    break;
                case "pen":
                    cur_pencil.AddPoint(e.X, e.Y);
                    break;
                case "line":
                    cur_line.end = e.Location;
                    break;
                default:
                    if (cur_shape != null)
                    {
                        cur_shape.Resize(e.X, e.Y, start);
                    }
                    break;
            }
            draw_panel.Invalidate();
        }
        /// <summary>
        /// События, происходящие при отпускании ЛКМ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void draw_panel_MouseUp(object sender, MouseEventArgs e)
        {
            switch (cur_mode)
            {
                case "pen":
                    pencils.Add(cur_pencil);
                    break;
                case "line":
                    lines.Add(cur_line);
                    break;
                default:
                    if (mods.SelectedItems.Count > 0)
                    {
                        cur_mode = mods.SelectedItems[0].Text;
                    }
                    break;
            }

        }
        /// <summary>
        /// Событие рисования
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void draw_panel_Paint(object sender, PaintEventArgs e)
        {
            foreach (Shape cur in shapes)
            {
                Pen pen = new Pen(cur.Color, 10);
                SolidBrush brush = new SolidBrush(cur.Color);
                cur.Show(e.Graphics, pen, brush);
            }
            if (cur_pencil != null)
            {
                Pen pen = new Pen(cur_pencil.Color, 10);
                cur_pencil.Draw(e.Graphics, pen);
            }
            if (cur_line != null)
            {
                Pen pen = new Pen(cur_line.Color, 10);
                cur_line.Draw(e.Graphics, pen);
            }
            if (!pencils.Contains(null))
            {
                foreach (Pencil pc in pencils)
                {
                    Pen pen = new Pen(pc.Color, width);
                    pc.Draw(e.Graphics, pen);
                }
            }
            if (!lines.Contains(null))
            {
                foreach (Line ln in lines)
                {
                    Pen pen = new Pen(ln.Color, 10);
                    ln.Draw(e.Graphics, pen);
                }
            }


        }
        /// <summary>
        /// Выбор режима рисования
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mods_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mods.SelectedItems.Count > 0)
            {
                cur_mode = mods.SelectedItems[0].Text;
            }
        }
        /// <summary>
        /// Выбор цвета для рисования
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void colors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cur_shape != null && colors.SelectedItems.Count > 0 && (cur_mode == "edit" || cur_mode == "editSize"))
            {
                color = colors.SelectedItems[0].Text;
                cur_shape.Color = Color.FromName(color);
                draw_panel.Invalidate();
            }
            else if (colors.SelectedItems.Count > 0)
            {
                color = colors.SelectedItems[0].Text;
                draw_panel.Invalidate();
            }
        }
        /// <summary>
        /// Удаление выбранной фигуры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void delete_Click(object sender, EventArgs e)
        {
            if (cur_shape != null)
            {
                shapes.Remove(cur_shape);
                draw_panel.Invalidate();
            }
        }

        //сдлеать выбор места и имени файла
        private void jpeg_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Title = "Сохранить изображение";
            fd.Filter = "JPG(*.JPG)|*.jpg;";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                if (draw_panel.Image != null)
                {
                    draw_panel.Image.Save(fd.FileName);
                }
            }
            else
            {
                return;
            }
        }



        //сдлеать выбор места и имени файла
        private void create_func_info_Click(object sender, EventArgs e)
        {
            Parser p = new Parser();
            p.CreateParseInfo(ref shapes, ref pencils, ref lines, "balabama.txt");
        }

        //сдлеать выбор файла
        private void loadFunc_Click(object sender, EventArgs e)
        {
            Parser p = new Parser();
            shapes = p.ParseFuncObjects("balabama.txt");
            pencils = p.ParseFuncObjectsPens("balabama.txt");
            lines = p.ParseFuncObjectsLines("balabama.txt");
            draw_panel.Invalidate();
        }
        /// <summary>
        /// Изменение толщины пера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            width = trackBar1.Value;
        }

        /// <summary>
        /// Выбор цвета из палитры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog1.Color.Name;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = "";
            OpenFileDialog fd = new OpenFileDialog();
            fd.Title = "Выберите изображение";
            fd.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                path = fd.FileName;
                draw_panel.Image = new Bitmap(path);
            }
            else
            {
                return;
            }
        }
    }
}
