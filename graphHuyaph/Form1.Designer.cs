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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "ell" }, -1, Color.Empty, Color.Empty, new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204));
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "rect" }, -1, Color.Empty, Color.Empty, new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204));
            ListViewItem listViewItem3 = new ListViewItem(new string[] { "rtrg" }, -1, Color.Empty, Color.Empty, new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204));
            ListViewItem listViewItem4 = new ListViewItem(new string[] { "sqr" }, -1, Color.Empty, Color.Empty, new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204));
            ListViewItem listViewItem5 = new ListViewItem(new string[] { "crc" }, -1, Color.Empty, Color.Empty, new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204));
            ListViewItem listViewItem6 = new ListViewItem(new string[] { "str" }, -1, Color.Empty, Color.Empty, new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204));
            ListViewItem listViewItem7 = new ListViewItem(new string[] { "edit" }, -1, Color.Empty, Color.Empty, new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204));
            ListViewItem listViewItem8 = new ListViewItem(new string[] { "editSize" }, -1, Color.Empty, Color.Empty, new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204));
            ListViewItem listViewItem9 = new ListViewItem(new string[] { "pen" }, -1, Color.Empty, Color.Empty, new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204));
            ListViewItem listViewItem10 = new ListViewItem(new string[] { "line" }, -1, Color.Empty, Color.Empty, new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204));
            ListViewItem listViewItem11 = new ListViewItem(new string[] { "trg" }, -1, Color.Empty, Color.Empty, new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204));
            ListViewItem listViewItem12 = new ListViewItem(new string[] { "ppt" }, -1, Color.Empty, Color.Empty, new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204));
            ListViewItem listViewItem13 = new ListViewItem("Green");
            ListViewItem listViewItem14 = new ListViewItem("Blue");
            draw_panel = new PictureBox();
            mods = new ListView();
            colors = new ListView();
            delete = new Button();
            jpeg_save = new Button();
            create_func_info = new Button();
            loadFunc = new Button();
            colorDialog1 = new ColorDialog();
            trackBar1 = new TrackBar();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)draw_panel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // draw_panel
            // 
            draw_panel.Location = new Point(0, 121);
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
            mods.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4, listViewItem5, listViewItem6, listViewItem7, listViewItem8, listViewItem9, listViewItem10, listViewItem11, listViewItem12 });
            mods.Location = new Point(213, 19);
            mods.MultiSelect = false;
            mods.Name = "mods";
            mods.Size = new Size(359, 96);
            mods.TabIndex = 1;
            mods.UseCompatibleStateImageBehavior = false;
            mods.SelectedIndexChanged += mods_SelectedIndexChanged;
            // 
            // colors
            // 
            colors.Items.AddRange(new ListViewItem[] { listViewItem13, listViewItem14 });
            colors.Location = new Point(12, 19);
            colors.MultiSelect = false;
            colors.Name = "colors";
            colors.Size = new Size(112, 45);
            colors.TabIndex = 2;
            colors.UseCompatibleStateImageBehavior = false;
            colors.SelectedIndexChanged += colors_SelectedIndexChanged;
            // 
            // delete
            // 
            delete.Location = new Point(1002, 12);
            delete.Name = "delete";
            delete.Size = new Size(75, 23);
            delete.TabIndex = 3;
            delete.Text = "Удалить";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // jpeg_save
            // 
            jpeg_save.Location = new Point(1002, 41);
            jpeg_save.Name = "jpeg_save";
            jpeg_save.Size = new Size(75, 23);
            jpeg_save.TabIndex = 4;
            jpeg_save.Text = "джепега";
            jpeg_save.UseVisualStyleBackColor = true;
            jpeg_save.Click += jpeg_save_Click;
            // 
            // create_func_info
            // 
            create_func_info.Location = new Point(1003, 70);
            create_func_info.Name = "create_func_info";
            create_func_info.Size = new Size(75, 23);
            create_func_info.TabIndex = 5;
            create_func_info.Text = "парсинфа";
            create_func_info.UseVisualStyleBackColor = true;
            create_func_info.Click += create_func_info_Click;
            // 
            // loadFunc
            // 
            loadFunc.Location = new Point(802, 12);
            loadFunc.Name = "loadFunc";
            loadFunc.Size = new Size(167, 23);
            loadFunc.TabIndex = 6;
            loadFunc.Text = "загрузить(не джепегу)";
            loadFunc.UseVisualStyleBackColor = true;
            loadFunc.Click += loadFunc_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(578, 59);
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
            button1.Location = new Point(117, 83);
            button1.Name = "button1";
            button1.Size = new Size(63, 33);
            button1.TabIndex = 8;
            button1.Text = "палитра";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(804, 51);
            button2.Name = "button2";
            button2.Size = new Size(166, 26);
            button2.TabIndex = 9;
            button2.Text = "загрузить(джепегу)";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 605);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(trackBar1);
            Controls.Add(loadFunc);
            Controls.Add(create_func_info);
            Controls.Add(jpeg_save);
            Controls.Add(delete);
            Controls.Add(colors);
            Controls.Add(mods);
            Controls.Add(draw_panel);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)draw_panel).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}
