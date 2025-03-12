namespace graphHuyaph
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ListViewItem listViewItem15 = new ListViewItem(new string[] { "ell" }, 0, Color.Empty, Color.Empty, new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204));
            ListViewItem listViewItem16 = new ListViewItem(new string[] { "rect" }, 1, Color.Empty, Color.Empty, new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204));
            ListViewItem listViewItem17 = new ListViewItem(new string[] { "rtrg" }, 10, Color.Empty, Color.Empty, new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204));
            ListViewItem listViewItem18 = new ListViewItem(new string[] { "sqr" }, 3, Color.Empty, Color.Empty, new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204));
            ListViewItem listViewItem19 = new ListViewItem(new string[] { "crc" }, 4, Color.Empty, Color.Empty, new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204));
            ListViewItem listViewItem20 = new ListViewItem(new string[] { "str" }, 5, Color.Empty, Color.Empty, new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204));
            ListViewItem listViewItem21 = new ListViewItem(new string[] { "edit" }, 6, Color.Empty, Color.Empty, new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204));
            ListViewItem listViewItem22 = new ListViewItem(new string[] { "editSize" }, 7, Color.Empty, Color.Empty, new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204));
            ListViewItem listViewItem23 = new ListViewItem(new string[] { "pen" }, 8, Color.Empty, Color.Empty, new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204));
            ListViewItem listViewItem24 = new ListViewItem(new string[] { "line" }, 9, Color.Empty, Color.Empty, new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204));
            ListViewItem listViewItem25 = new ListViewItem(new string[] { "trg" }, 2, Color.Empty, Color.Empty, new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204));
            ListViewItem listViewItem26 = new ListViewItem(new string[] { "ppt" }, 11, Color.Empty, Color.Empty, new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204));
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ListViewItem listViewItem1 = new ListViewItem("Green");
            ListViewItem listViewItem2 = new ListViewItem("Blue");
            draw_panel = new PictureBox();
            mods = new ListView();
            imageList1 = new ImageList(components);
            colors = new ListView();
            delete = new Button();
            jpeg_save = new Button();
            create_func_info = new Button();
            loadFunc = new Button();
            colorDialog1 = new ColorDialog();
            trackBar1 = new TrackBar();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)draw_panel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // draw_panel
            // 
            draw_panel.Location = new Point(3, 122);
            draw_panel.Name = "draw_panel";
            draw_panel.Size = new Size(1120, 484);
            draw_panel.TabIndex = 0;
            draw_panel.TabStop = false;
            draw_panel.Paint += draw_panel_Paint;
            draw_panel.MouseDown += draw_panel_MouseDown;
            draw_panel.MouseMove += draw_panel_MouseMove;
            draw_panel.MouseUp += draw_panel_MouseUp;
            // 
            // mods
            // 
            listViewItem15.Checked = true;
            listViewItem15.StateImageIndex = 1;
            listViewItem16.Checked = true;
            listViewItem16.StateImageIndex = 2;
            mods.Items.AddRange(new ListViewItem[] { listViewItem15, listViewItem16, listViewItem17, listViewItem18, listViewItem19, listViewItem20, listViewItem21, listViewItem22, listViewItem23, listViewItem24, listViewItem25, listViewItem26 });
            mods.Location = new Point(397, 15);
            mods.MultiSelect = false;
            mods.Name = "mods";
            mods.Size = new Size(341, 108);
            mods.SmallImageList = imageList1;
            mods.TabIndex = 1;
            mods.UseCompatibleStateImageBehavior = false;
            mods.View = View.List;
            mods.SelectedIndexChanged += mods_SelectedIndexChanged;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "ellip.jpg");
            imageList1.Images.SetKeyName(1, "rect.jpg");
            imageList1.Images.SetKeyName(2, "trg.jpg");
            imageList1.Images.SetKeyName(3, "square.jpg");
            imageList1.Images.SetKeyName(4, "circle.jpg");
            imageList1.Images.SetKeyName(5, "zvezda.jpg");
            imageList1.Images.SetKeyName(6, "05ffb1b18c843b8bfced7bdfd857b8aa.jpg");
            imageList1.Images.SetKeyName(7, "zvezda (1).jpg");
            imageList1.Images.SetKeyName(8, "4480206tif1000x1000.jpg");
            imageList1.Images.SetKeyName(9, "line.jpg");
            imageList1.Images.SetKeyName(10, "trgp (1).jpg");
            imageList1.Images.SetKeyName(11, "pipetka.jpg");
            // 
            // colors
            // 
            colors.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            colors.Location = new Point(9, 15);
            colors.MultiSelect = false;
            colors.Name = "colors";
            colors.Size = new Size(147, 45);
            colors.TabIndex = 2;
            colors.UseCompatibleStateImageBehavior = false;
            colors.SelectedIndexChanged += colors_SelectedIndexChanged;
            // 
            // delete
            // 
            delete.BackColor = Color.ForestGreen;
            delete.Font = new Font("Elephant", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            delete.ForeColor = Color.SeaShell;
            delete.Location = new Point(744, 41);
            delete.Name = "delete";
            delete.Size = new Size(110, 45);
            delete.TabIndex = 3;
            delete.Text = "Удалить";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // jpeg_save
            // 
            jpeg_save.Location = new Point(994, 12);
            jpeg_save.Name = "jpeg_save";
            jpeg_save.Size = new Size(75, 23);
            jpeg_save.TabIndex = 4;
            jpeg_save.Text = "джепега";
            jpeg_save.UseVisualStyleBackColor = true;
            jpeg_save.Click += jpeg_save_Click;
            // 
            // create_func_info
            // 
            create_func_info.Location = new Point(1004, 86);
            create_func_info.Name = "create_func_info";
            create_func_info.Size = new Size(75, 23);
            create_func_info.TabIndex = 5;
            create_func_info.Text = "парсинфа";
            create_func_info.UseVisualStyleBackColor = true;
            create_func_info.Click += create_func_info_Click;
            // 
            // loadFunc
            // 
            loadFunc.Location = new Point(903, 63);
            loadFunc.Name = "loadFunc";
            loadFunc.Size = new Size(167, 23);
            loadFunc.TabIndex = 6;
            loadFunc.Text = "загрузить(не джепегу)";
            loadFunc.UseVisualStyleBackColor = true;
            loadFunc.Click += loadFunc_Click;
            // 
            // trackBar1
            // 
            trackBar1.BackColor = Color.DarkSeaGreen;
            trackBar1.Location = new Point(185, 74);
            trackBar1.Maximum = 30;
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(195, 45);
            trackBar1.TabIndex = 7;
            trackBar1.Value = 10;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // button1
            // 
            button1.Location = new Point(9, 76);
            button1.Name = "button1";
            button1.Size = new Size(147, 33);
            button1.TabIndex = 8;
            button1.Text = "палитра";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(903, 34);
            button2.Name = "button2";
            button2.Size = new Size(166, 26);
            button2.TabIndex = 9;
            button2.Text = "загрузить(джепегу)";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(trackBar1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(loadFunc);
            panel1.Controls.Add(create_func_info);
            panel1.Controls.Add(mods);
            panel1.Controls.Add(jpeg_save);
            panel1.Controls.Add(delete);
            panel1.Controls.Add(colors);
            panel1.Location = new Point(3, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1120, 126);
            panel1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Elephant", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(185, 31);
            label1.Name = "label1";
            label1.Size = new Size(177, 27);
            label1.TabIndex = 10;
            label1.Text = "Толщина ручки";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1119, 605);
            Controls.Add(panel1);
            Controls.Add(draw_panel);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)draw_panel).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox draw_panel;
        private ListView mods;
        private ListView colors;
        private Button delete;
        private Button jpeg_save;
        private Button create_func_info;
        private Button loadFunc;
        private ColorDialog colorDialog1;
        private TrackBar trackBar1;
        private Button button1;
        private Button button2;
        private ImageList imageList1;
        private Panel panel1;
        private Label label1;
    }
}
