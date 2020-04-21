namespace FordBell
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.start = new System.Windows.Forms.ComboBox();
            this.end = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pb = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lưuẢnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaDữLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTácGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lienthong = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.dt = new System.Windows.Forms.DataGridView();
            this.tb = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(10, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Nhập từ File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // start
            // 
            this.start.Enabled = false;
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.FormattingEnabled = true;
            this.start.Location = new System.Drawing.Point(785, 13);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(51, 28);
            this.start.TabIndex = 6;
            // 
            // end
            // 
            this.end.Enabled = false;
            this.end.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end.FormattingEnabled = true;
            this.end.Location = new System.Drawing.Point(881, 14);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(51, 28);
            this.end.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(753, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Từ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(839, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Đến";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(602, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 30);
            this.button2.TabIndex = 10;
            this.button2.Text = "Tìm Đường đi ngắn nhất";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pb
            // 
            this.pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb.ContextMenuStrip = this.contextMenuStrip1;
            this.pb.Location = new System.Drawing.Point(1, 53);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(935, 438);
            this.pb.TabIndex = 2;
            this.pb.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lưuẢnhToolStripMenuItem,
            this.sửaDữLiệuToolStripMenuItem,
            this.cậpNhậtToolStripMenuItem,
            this.thôngTinTácGiảToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(164, 92);
            // 
            // lưuẢnhToolStripMenuItem
            // 
            this.lưuẢnhToolStripMenuItem.Name = "lưuẢnhToolStripMenuItem";
            this.lưuẢnhToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.lưuẢnhToolStripMenuItem.Text = "Lưu Ảnh Đồ Thị";
            this.lưuẢnhToolStripMenuItem.Click += new System.EventHandler(this.lưuẢnhToolStripMenuItem_Click);
            // 
            // sửaDữLiệuToolStripMenuItem
            // 
            this.sửaDữLiệuToolStripMenuItem.Name = "sửaDữLiệuToolStripMenuItem";
            this.sửaDữLiệuToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            // 
            // cậpNhậtToolStripMenuItem
            // 
            this.cậpNhậtToolStripMenuItem.Name = "cậpNhậtToolStripMenuItem";
            this.cậpNhậtToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.cậpNhậtToolStripMenuItem.Text = "Cập nhật";
            this.cậpNhậtToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtToolStripMenuItem_Click);
            // 
            // thôngTinTácGiảToolStripMenuItem
            // 
            this.thôngTinTácGiảToolStripMenuItem.Name = "thôngTinTácGiảToolStripMenuItem";
            this.thôngTinTácGiảToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.thôngTinTácGiảToolStripMenuItem.Text = "Thông tin tác giả";
            this.thôngTinTácGiảToolStripMenuItem.Click += new System.EventHandler(this.BackHome_ToolStripMenuItem_Click);
            // 
            // lienthong
            // 
            this.lienthong.AutoSize = true;
            this.lienthong.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lienthong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lienthong.Location = new System.Drawing.Point(268, 9);
            this.lienthong.Name = "lienthong";
            this.lienthong.Size = new System.Drawing.Size(0, 31);
            this.lienthong.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(92, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 35);
            this.button3.TabIndex = 13;
            this.button3.Text = "Nhập bằng tay";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dt
            // 
            this.dt.AllowUserToAddRows = false;
            this.dt.AllowUserToDeleteRows = false;
            this.dt.AllowUserToResizeColumns = false;
            this.dt.AllowUserToResizeRows = false;
            this.dt.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dt.DefaultCellStyle = dataGridViewCellStyle1;
            this.dt.GridColor = System.Drawing.SystemColors.Control;
            this.dt.Location = new System.Drawing.Point(791, 188);
            this.dt.Name = "dt";
            this.dt.ReadOnly = true;
            this.dt.RowHeadersVisible = false;
            this.dt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dt.Size = new System.Drawing.Size(141, 20);
            this.dt.TabIndex = 14;
            this.dt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_CellClick);
            // 
            // tb
            // 
            this.tb.AutoSize = true;
            this.tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb.Location = new System.Drawing.Point(16, 503);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(0, 25);
            this.tb.TabIndex = 15;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(177, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 35);
            this.button4.TabIndex = 16;
            this.button4.Text = "Cập nhật";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(261, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 35);
            this.button5.TabIndex = 18;
            this.button5.Text = "Thoát";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 364);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.ControlBox = false;
            this.Controls.Add(this.button5);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.lienthong);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.end);
            this.Controls.Add(this.start);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo Tìm đường đi ngắn nhất ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox start;
        private System.Windows.Forms.ComboBox end;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.Label lienthong;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lưuẢnhToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dt;
        private System.Windows.Forms.Label tb;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripMenuItem sửaDữLiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTácGiảToolStripMenuItem;
        private System.Windows.Forms.Button button5;
    }
}

