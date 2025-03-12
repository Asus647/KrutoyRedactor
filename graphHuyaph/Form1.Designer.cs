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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "ell" }, 0, Color.Empty, Color.Empty, new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204));
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "rect" }, 1, Color.Empty, Color.Empty, new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204));
            ListViewItem listViewItem3 = new ListViewItem(new string[] { "rtrg" }, 10, Color.Empty, Color.Empty, new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204));
            ListViewItem listViewItem4 = new ListViewItem(new string[] { "sqr" }, 3, Color.Empty, Color.Empty, new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204));
            ListViewItem listViewItem5 = new ListViewItem(new string[] { "crc" }, 4, Color.Empty, Color.Empty, new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204));
            ListViewItem listViewItem6 = new ListViewItem(new string[] { "str" }, 5, Color.Empty, Color.Empty, new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204));
            ListViewItem listViewItem7 = new ListViewItem(new string[] { "edit" }, 6, Color.Empty, Color.Empty, new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204));
            ListViewItem listViewItem8 = new ListViewItem(new string[] { "editSize" }, 7, Color.Empty, Color.Empty, new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204));
            ListViewItem listViewItem9 = new ListViewItem(new string[] { "pen" }, 8, Color.Empty, Color.Empty, new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204));
            ListViewItem listViewItem10 = new ListViewItem(new string[] { "line" }, 9, Color.Empty, Color.Empty, new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204));
            ListViewItem listViewItem11 = new ListViewItem(new string[] { "trg" }, 2, Color.Empty, Color.Empty, new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204));
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            draw_panel = new PictureBox();
            mods = new ListView();
            imageList1 = new ImageList(components);
            clear = new Button();
            jpeg_save = new Button();
            create_func_info = new Button();
            loadFunc = new Button();
            colorDialog1 = new ColorDialog();
            trackBar1 = new TrackBar();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            delete = new Button();
            panel2 = new Panel();
            button12 = new Button();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button8 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)draw_panel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // draw_panel
            // 
            draw_panel.Location = new Point(3, 163);
            draw_panel.Margin = new Padding(3, 4, 3, 4);
            draw_panel.Name = "draw_panel";
            draw_panel.Size = new Size(1280, 645);
            draw_panel.TabIndex = 0;
            draw_panel.TabStop = false;
            draw_panel.Paint += draw_panel_Paint;
            draw_panel.MouseDown += draw_panel_MouseDown;
            draw_panel.MouseMove += draw_panel_MouseMove;
            draw_panel.MouseUp += draw_panel_MouseUp;
            // 
            // mods
            // 
            listViewItem1.Checked = true;
            listViewItem1.StateImageIndex = 1;
            listViewItem2.Checked = true;
            listViewItem2.StateImageIndex = 2;
            mods.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4, listViewItem5, listViewItem6, listViewItem7, listViewItem8, listViewItem9, listViewItem10, listViewItem11 });
            mods.Location = new Point(454, 20);
            mods.Margin = new Padding(3, 4, 3, 4);
            mods.MultiSelect = false;
            mods.Name = "mods";
            mods.Size = new Size(389, 143);
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
            // clear
            // 
            clear.BackColor = Color.ForestGreen;
            clear.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clear.ForeColor = Color.SeaShell;
            clear.Location = new Point(884, 92);
            clear.Margin = new Padding(3, 4, 3, 4);
            clear.Name = "clear";
            clear.Size = new Size(139, 60);
            clear.TabIndex = 3;
            clear.Text = "Очистить";
            clear.UseVisualStyleBackColor = false;
            clear.Click += clear_Click;
            // 
            // jpeg_save
            // 
            jpeg_save.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            jpeg_save.Location = new Point(1064, 6);
            jpeg_save.Margin = new Padding(3, 4, 3, 4);
            jpeg_save.Name = "jpeg_save";
            jpeg_save.Size = new Size(200, 41);
            jpeg_save.TabIndex = 4;
            jpeg_save.Text = "Сохранить";
            jpeg_save.UseVisualStyleBackColor = true;
            jpeg_save.Click += jpeg_save_Click;
            // 
            // create_func_info
            // 
            create_func_info.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            create_func_info.Location = new Point(1064, 48);
            create_func_info.Margin = new Padding(3, 4, 3, 4);
            create_func_info.Name = "create_func_info";
            create_func_info.Size = new Size(200, 36);
            create_func_info.TabIndex = 5;
            create_func_info.Text = "Анализатор";
            create_func_info.UseVisualStyleBackColor = true;
            create_func_info.Click += create_func_info_Click;
            // 
            // loadFunc
            // 
            loadFunc.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loadFunc.Location = new Point(1064, 129);
            loadFunc.Margin = new Padding(3, 4, 3, 4);
            loadFunc.Name = "loadFunc";
            loadFunc.Size = new Size(200, 38);
            loadFunc.TabIndex = 6;
            loadFunc.Text = "Загрузить(info)";
            loadFunc.UseVisualStyleBackColor = true;
            loadFunc.Click += loadFunc_Click;
            // 
            // trackBar1
            // 
            trackBar1.BackColor = Color.DarkSeaGreen;
            trackBar1.Location = new Point(211, 99);
            trackBar1.Margin = new Padding(3, 4, 3, 4);
            trackBar1.Maximum = 30;
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(223, 56);
            trackBar1.TabIndex = 7;
            trackBar1.Value = 10;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // button1
            // 
            button1.Location = new Point(29, 115);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(157, 31);
            button1.TabIndex = 8;
            button1.Text = "Палитра";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(1064, 85);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(200, 43);
            button2.TabIndex = 9;
            button2.Text = "Загрузить(jpg)";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(delete);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(trackBar1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(loadFunc);
            panel1.Controls.Add(create_func_info);
            panel1.Controls.Add(mods);
            panel1.Controls.Add(jpeg_save);
            panel1.Controls.Add(clear);
            panel1.Location = new Point(3, -4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1280, 168);
            panel1.TabIndex = 10;
            // 
            // delete
            // 
            delete.BackColor = Color.ForestGreen;
            delete.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            delete.ForeColor = Color.SeaShell;
            delete.Location = new Point(884, 24);
            delete.Margin = new Padding(3, 4, 3, 4);
            delete.Name = "delete";
            delete.Size = new Size(139, 60);
            delete.TabIndex = 12;
            delete.Text = "Удалить";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(button12);
            panel2.Controls.Add(button11);
            panel2.Controls.Add(button10);
            panel2.Controls.Add(button9);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button8);
            panel2.Location = new Point(9, 16);
            panel2.Name = "panel2";
            panel2.Size = new Size(196, 82);
            panel2.TabIndex = 11;
            // 
            // button12
            // 
            button12.BackColor = Color.Purple;
            button12.Location = new Point(160, 42);
            button12.Name = "button12";
            button12.Size = new Size(33, 33);
            button12.TabIndex = 14;
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(255, 192, 255);
            button11.Location = new Point(120, 42);
            button11.Name = "button11";
            button11.Size = new Size(33, 33);
            button11.TabIndex = 13;
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(192, 255, 255);
            button10.Location = new Point(81, 42);
            button10.Name = "button10";
            button10.Size = new Size(33, 33);
            button10.TabIndex = 12;
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(255, 128, 0);
            button9.Location = new Point(42, 42);
            button9.Name = "button9";
            button9.Size = new Size(33, 33);
            button9.TabIndex = 11;
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Lime;
            button7.Location = new Point(3, 42);
            button7.Name = "button7";
            button7.Size = new Size(33, 33);
            button7.TabIndex = 10;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Yellow;
            button6.Location = new Point(159, 3);
            button6.Name = "button6";
            button6.Size = new Size(33, 33);
            button6.TabIndex = 9;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Red;
            button5.Location = new Point(120, 3);
            button5.Name = "button5";
            button5.Size = new Size(33, 33);
            button5.TabIndex = 8;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Blue;
            button4.Location = new Point(81, 3);
            button4.Name = "button4";
            button4.Size = new Size(33, 33);
            button4.TabIndex = 7;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(42, 3);
            button3.Name = "button3";
            button3.Size = new Size(33, 33);
            button3.TabIndex = 6;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Black;
            button8.Location = new Point(3, 3);
            button8.Name = "button8";
            button8.Size = new Size(33, 33);
            button8.TabIndex = 5;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(211, 41);
            label1.Name = "label1";
            label1.Size = new Size(220, 31);
            label1.TabIndex = 10;
            label1.Text = "Толщина ручки";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1282, 807);
            Controls.Add(panel1);
            Controls.Add(draw_panel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)draw_panel).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox draw_panel;
        private ListView mods;
        private Button clear;
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
        private Panel panel2;
        private Button button8;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button delete;
    }
}
