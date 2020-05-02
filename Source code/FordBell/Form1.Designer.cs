namespace ployd
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
            this.btl_NhapFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.start = new System.Windows.Forms.ComboBox();
            this.end = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btl_ToanBo = new System.Windows.Forms.Button();
            this.pb = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lưuẢnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaDữLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTácGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lienthong = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btl_NhapTay = new System.Windows.Forms.Button();
            this.dt = new System.Windows.Forms.DataGridView();
            this.tb = new System.Windows.Forms.Label();
            this.btl_CapNhat = new System.Windows.Forms.Button();
            this.btl_Thoat = new System.Windows.Forms.Button();
            this.cb_GiaiThuat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btl_Truoc = new System.Windows.Forms.Button();
            this.btl_Sau = new System.Windows.Forms.Button();
            this.btl_OK = new System.Windows.Forms.Button();
            this.lab_TieuDe = new System.Windows.Forms.Label();
            this.lab_HienThi = new System.Windows.Forms.Label();
            this.lab_dd = new System.Windows.Forms.Label();
            this.lab_HienThi1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt)).BeginInit();
            this.SuspendLayout();
            // 
            // btl_NhapFile
            // 
            this.btl_NhapFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btl_NhapFile.Location = new System.Drawing.Point(10, 12);
            this.btl_NhapFile.Name = "btl_NhapFile";
            this.btl_NhapFile.Size = new System.Drawing.Size(82, 35);
            this.btl_NhapFile.TabIndex = 3;
            this.btl_NhapFile.Text = "Nhập từ File";
            this.btl_NhapFile.UseVisualStyleBackColor = true;
            this.btl_NhapFile.Click += new System.EventHandler(this.button1_Click);
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
            this.start.Location = new System.Drawing.Point(702, 11);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(51, 28);
            this.start.TabIndex = 6;
            // 
            // end
            // 
            this.end.Enabled = false;
            this.end.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end.FormattingEnabled = true;
            this.end.Location = new System.Drawing.Point(807, 11);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(51, 28);
            this.end.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(667, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Từ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(759, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Đến";
            // 
            // btl_ToanBo
            // 
            this.btl_ToanBo.Enabled = false;
            this.btl_ToanBo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btl_ToanBo.Location = new System.Drawing.Point(213, 498);
            this.btl_ToanBo.Name = "btl_ToanBo";
            this.btl_ToanBo.Size = new System.Drawing.Size(76, 30);
            this.btl_ToanBo.TabIndex = 10;
            this.btl_ToanBo.Text = "Toàn bộ";
            this.btl_ToanBo.UseVisualStyleBackColor = true;
            this.btl_ToanBo.Click += new System.EventHandler(this.button2_Click);
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
            // btl_NhapTay
            // 
            this.btl_NhapTay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btl_NhapTay.Location = new System.Drawing.Point(92, 12);
            this.btl_NhapTay.Name = "btl_NhapTay";
            this.btl_NhapTay.Size = new System.Drawing.Size(85, 35);
            this.btl_NhapTay.TabIndex = 13;
            this.btl_NhapTay.Text = "Nhập bằng tay";
            this.btl_NhapTay.UseVisualStyleBackColor = true;
            this.btl_NhapTay.Click += new System.EventHandler(this.button3_Click);
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
            // btl_CapNhat
            // 
            this.btl_CapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btl_CapNhat.Location = new System.Drawing.Point(207, 12);
            this.btl_CapNhat.Name = "btl_CapNhat";
            this.btl_CapNhat.Size = new System.Drawing.Size(82, 35);
            this.btl_CapNhat.TabIndex = 16;
            this.btl_CapNhat.Text = "Cập nhật";
            this.btl_CapNhat.UseVisualStyleBackColor = true;
            this.btl_CapNhat.Click += new System.EventHandler(this.button4_Click);
            // 
            // btl_Thoat
            // 
            this.btl_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btl_Thoat.ForeColor = System.Drawing.Color.Red;
            this.btl_Thoat.Location = new System.Drawing.Point(854, 501);
            this.btl_Thoat.Name = "btl_Thoat";
            this.btl_Thoat.Size = new System.Drawing.Size(82, 35);
            this.btl_Thoat.TabIndex = 18;
            this.btl_Thoat.Text = "Thoát";
            this.btl_Thoat.UseVisualStyleBackColor = true;
            this.btl_Thoat.Click += new System.EventHandler(this.button5_Click);
            // 
            // cb_GiaiThuat
            // 
            this.cb_GiaiThuat.DropDownHeight = 120;
            this.cb_GiaiThuat.FormattingEnabled = true;
            this.cb_GiaiThuat.IntegralHeight = false;
            this.cb_GiaiThuat.ItemHeight = 13;
            this.cb_GiaiThuat.Items.AddRange(new object[] {
            "Dijkstra",
            "Bellman-Ford",
            "Floyd-Warshall",
            "A*"});
            this.cb_GiaiThuat.Location = new System.Drawing.Point(438, 16);
            this.cb_GiaiThuat.Name = "cb_GiaiThuat";
            this.cb_GiaiThuat.Size = new System.Drawing.Size(121, 21);
            this.cb_GiaiThuat.TabIndex = 19;
            this.cb_GiaiThuat.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(351, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Giải Thuật";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btl_Truoc
            // 
            this.btl_Truoc.Location = new System.Drawing.Point(29, 497);
            this.btl_Truoc.Name = "btl_Truoc";
            this.btl_Truoc.Size = new System.Drawing.Size(63, 31);
            this.btl_Truoc.TabIndex = 21;
            this.btl_Truoc.Text = "Trước";
            this.btl_Truoc.UseVisualStyleBackColor = true;
            this.btl_Truoc.Click += new System.EventHandler(this.btl_Truoc_Click);
            // 
            // btl_Sau
            // 
            this.btl_Sau.Location = new System.Drawing.Point(98, 497);
            this.btl_Sau.Name = "btl_Sau";
            this.btl_Sau.Size = new System.Drawing.Size(63, 31);
            this.btl_Sau.TabIndex = 22;
            this.btl_Sau.Text = "Sau";
            this.btl_Sau.UseVisualStyleBackColor = true;
            this.btl_Sau.Click += new System.EventHandler(this.btl_Sau_Click);
            // 
            // btl_OK
            // 
            this.btl_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btl_OK.Location = new System.Drawing.Point(873, 11);
            this.btl_OK.Name = "btl_OK";
            this.btl_OK.Size = new System.Drawing.Size(63, 28);
            this.btl_OK.TabIndex = 23;
            this.btl_OK.Text = "OK";
            this.btl_OK.UseVisualStyleBackColor = true;
            this.btl_OK.Click += new System.EventHandler(this.btl_OK_Click);
            // 
            // lab_TieuDe
            // 
            this.lab_TieuDe.AutoSize = true;
            this.lab_TieuDe.Location = new System.Drawing.Point(458, 501);
            this.lab_TieuDe.Name = "lab_TieuDe";
            this.lab_TieuDe.Size = new System.Drawing.Size(0, 13);
            this.lab_TieuDe.TabIndex = 24;
            // 
            // lab_HienThi
            // 
            this.lab_HienThi.AutoSize = true;
            this.lab_HienThi.Location = new System.Drawing.Point(580, 501);
            this.lab_HienThi.Name = "lab_HienThi";
            this.lab_HienThi.Size = new System.Drawing.Size(0, 13);
            this.lab_HienThi.TabIndex = 25;
            // 
            // lab_dd
            // 
            this.lab_dd.AutoSize = true;
            this.lab_dd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_dd.Location = new System.Drawing.Point(381, 503);
            this.lab_dd.Name = "lab_dd";
            this.lab_dd.Size = new System.Drawing.Size(91, 20);
            this.lab_dd.TabIndex = 26;
            this.lab_dd.Text = "Đường đi :";
            // 
            // lab_HienThi1
            // 
            this.lab_HienThi1.AutoSize = true;
            this.lab_HienThi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_HienThi1.ForeColor = System.Drawing.Color.ForestGreen;
            this.lab_HienThi1.Location = new System.Drawing.Point(478, 504);
            this.lab_HienThi1.Name = "lab_HienThi1";
            this.lab_HienThi1.Size = new System.Drawing.Size(0, 16);
            this.lab_HienThi1.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 545);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.ControlBox = false;
            this.Controls.Add(this.lab_HienThi1);
            this.Controls.Add(this.lab_dd);
            this.Controls.Add(this.lab_HienThi);
            this.Controls.Add(this.lab_TieuDe);
            this.Controls.Add(this.btl_OK);
            this.Controls.Add(this.btl_Sau);
            this.Controls.Add(this.btl_Truoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_GiaiThuat);
            this.Controls.Add(this.btl_Thoat);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.lienthong);
            this.Controls.Add(this.btl_CapNhat);
            this.Controls.Add(this.dt);
            this.Controls.Add(this.btl_ToanBo);
            this.Controls.Add(this.btl_NhapTay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.end);
            this.Controls.Add(this.start);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.btl_NhapFile);
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

        private System.Windows.Forms.Button btl_NhapFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox start;
        private System.Windows.Forms.ComboBox end;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btl_ToanBo;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.Label lienthong;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lưuẢnhToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btl_NhapTay;
        private System.Windows.Forms.DataGridView dt;
        private System.Windows.Forms.Label tb;
        private System.Windows.Forms.Button btl_CapNhat;
        private System.Windows.Forms.ToolStripMenuItem sửaDữLiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTácGiảToolStripMenuItem;
        private System.Windows.Forms.Button btl_Thoat;
        private System.Windows.Forms.ComboBox cb_GiaiThuat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btl_Truoc;
        private System.Windows.Forms.Button btl_Sau;
        private System.Windows.Forms.Button btl_OK;
        private System.Windows.Forms.Label lab_TieuDe;
        private System.Windows.Forms.Label lab_HienThi;
        private System.Windows.Forms.Label lab_dd;
        private System.Windows.Forms.Label lab_HienThi1;
    }
}

