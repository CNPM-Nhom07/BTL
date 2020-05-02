using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ployd
{
    public partial class Form1 : Form
    {
        const int vocung = 9999999;
        int[] dd= new int[10];
        int n = 0;
        int vt = 0;
        public Form1()
        {
            InitializeComponent();
        }


        FB a;
       // private int[] dd = a.DuongDi[];

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                openFileDialog1.Filter = "Tập tin đồ thị | *.txt";
                openFileDialog1.ShowDialog();

                a = new FB(openFileDialog1.FileName);

                if (a.KiemTraVoHuong())
                {
                    start.Items.Clear();
                    end.Items.Clear();
                    for (int i = 1; i <= a.SoDinh; i++)
                    {
                        start.Items.Add(i);
                        end.Items.Add(i);
                    }
                    end.Enabled = start.Enabled = true;
                    btl_ToanBo.Enabled = true;
                    end.Text = a.SoDinh.ToString();
                    start.Text = "1";


                    pb.Image = a.Paint();
                    if (a.DFS(1))
                    {
                        lienthong.Text = "Đồ thị Liên thông";

                    }
                    else
                        lienthong.Text = "Đồ thị Không Liên thông";
                    tam.matran = a.ToMaTrix;
                    tam.sodinh = a.SoDinh;
                    this.Width = 953;
                    btl_Thoat.Location = new Point(854, 503);
                    this.Text = "Demo Tìm đường đi ngắn nhất bằng Ford Bellman";
                    ToListView();
                }
                else
                {
                    MessageBox.Show("Đồ thị nhập vào không phải đồ thị Vô Hướng!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    button1_Click(sender, e);

                }


            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Đồ thị nhập vào không hợp lê!!! \r\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            this.Height = 578;


            btl_CapNhat.Enabled = contextMenuStrip1.Enabled = true;



        }


        void ToListView()
        {
            if (a.SoDinh > 0)
            {
                dt.Height = 50;
                dt.Columns.Add("Begin", "Begin");
                dt.Columns.Add("End", "End");
                dt.Columns.Add("Distance", "Distance");
                dt.Rows.Clear();

                dt.Columns[0].Width = 40;
                dt.Columns[1].Width = 40;
                dt.Columns[2].Width = 60;

                int row = 0;
                int[,] danhdau = new int[a.SoDinh, a.SoDinh];

                for (int i = 0; i < a.SoDinh; i++)
                {

                    for (int j = 0; j < a.SoDinh; j++)
                    {
                        if (a.ToMaTrix[i, j] != vocung && danhdau[i, j] == 0)
                        {
                            dt.Rows.Add();
                            if (dt.Height < 250)
                            {
                                dt.Height += 20;
                            }


                            dt[0, row].Value = i + 1;
                            dt[1, row].Value = j + 1;
                            dt[2, row].Value = a.ToMaTrix[i, j];
                            row++;
                            danhdau[i, j] = danhdau[j, i] = 1;

                        }
                    }

                }

            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (start.Text != end.Text)
                {
                    pb.Image = a.Paint();


                    string st = a.XuaKQ(int.Parse(start.Text) - 1, int.Parse(end.Text) - 1, pb.Image);



                    st = "Đường đi ngắn nhất từ " + start.Text + " đến " + end.Text + " : " + st + "  ||  ";
                    if (a.KhoangCach[Convert.ToInt32(end.Text) - 1] == vocung)
                    {
                        st += "Độ dài: ∞";
                    }
                    else
                    {
                        st += "Độ dài: " + a.KhoangCach[Convert.ToInt32(end.Text) - 1].ToString();
                        pb.Image = a.DuongDiPic(int.Parse(start.Text) - 1, int.Parse(end.Text) - 1, pb.Image);
                    }
                    tb.Text = st;
                }
                else
                {
                    MessageBox.Show("Bạn đang ở đó rồi nek !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            vt = n-2;           // Vi tri de duyet tung step
            btl_Sau.Enabled = false;
            btl_Truoc.Enabled = true;

        }

        void SaveImage(System.Drawing.Imaging.ImageFormat format)
        {
            try
            {

                saveFileDialog1.Filter = "Ảnh đồ thị | *.png";
                saveFileDialog1.ShowDialog();

                pb.Image.Save(saveFileDialog1.FileName, format);
            }
            catch (System.Exception ex)
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Width = 953;
            this.Text = "Demo Tìm đường đi ngắn nhất";
            btl_Thoat.Location = new Point(854, 503);
            this.Height = 578;
            Nhapmatran a = new Nhapmatran();
            btl_CapNhat.Enabled = contextMenuStrip1.Enabled = true;
            a.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cb_GiaiThuat.Enabled = false;
            btl_CapNhat.Enabled = contextMenuStrip1.Enabled = false;
            btl_Truoc.Enabled = contextMenuStrip1.Enabled = false;
            btl_Sau.Enabled = contextMenuStrip1.Enabled = false;
            btl_OK.Enabled = contextMenuStrip1.Enabled = false;


        }

        public void button4_Click(object sender, EventArgs e)
        {
            btl_OK.Enabled = contextMenuStrip1.Enabled = true;
            a = new FB(tam.sodinh, tam.matran);
            cb_GiaiThuat.Enabled = true;
            start.Items.Clear();
            end.Items.Clear();
            for (int i = 1; i <= a.SoDinh; i++)
            {
                start.Items.Add(i);
                end.Items.Add(i);
            }
            end.Enabled = start.Enabled = true;
            end.Text = a.SoDinh.ToString();
            start.Text = "1";


            pb.Image = a.Paint();
            /* if (a.DFS(1))
             {
                 lienthong.Text = "Đồ thị Liên thông";

             }
             else
                 lienthong.Text = "Đồ thị Không Liên thông";*/
            if (!a.DFS(1))
            {
                MessageBox.Show("Đồ thị Không Liên thông");

            }
            a.Paint();
            ToListView();
        }

        private void cậpNhậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button4_Click(sender, e);
        }

        private void BackHome_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.ShowDialog();
        }

        private void dt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pb.Image = a.Paint();

            int tam = e.RowIndex;
            PointF p1 = a.ViTriVe[Convert.ToInt32(dt[0, tam].Value) - 1];
            PointF p2 = a.ViTriVe[Convert.ToInt32(dt[1, tam].Value) - 1];
            int ts = a.ToMaTrix[Convert.ToInt32(dt[0, tam].Value) - 1, Convert.ToInt32(dt[1, tam].Value) - 1];
            pb.Image = a.LineTo(p1, p2, pb.Image, ts, Color.Yellow);

        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            About a = new About();
            a.ShowDialog();
        }


        private void lưuẢnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveImage(System.Drawing.Imaging.ImageFormat.Png);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btl_OK_Click(object sender, EventArgs e)
        {
            //Lấy giá trị qua thuộc tính SelectedItem
            var item = this.cb_GiaiThuat.GetItemText(this.cb_GiaiThuat.SelectedItem);
            if (item == "")
                MessageBox.Show("Vui lòng chọn thuật toán !!!");
            else
            {
                btl_Sau.Enabled = contextMenuStrip1.Enabled = true;
                btl_ToanBo.Enabled = contextMenuStrip1.Enabled = true;
                int bd = int.Parse(start.Text) - 1;
                int kt = int.Parse(end.Text) - 1;
                a.Floyd(bd);
                a.TimDuong(bd, kt);
                int[] tmp = a.DuongDi;
                n = 0;
                string s = "";
                for (int i = tmp.Length - 1; i >= 0; i--)
                    if (Convert.ToInt32(tmp[i]) != 0) { dd[n++] = Convert.ToInt32(tmp[i]); s += tmp[i] + " "; }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        
        private void btl_Sau_Click(object sender, EventArgs e)
        {
            if (vt == n - 2) { btl_Sau.Enabled = false;  }
            int ts = a.ToMaTrix[dd[vt]-1, dd[vt+1]-1];
            PointF p1 = a.ViTriVe[dd[vt] - 1];
            PointF p2 = a.ViTriVe[dd[vt+1] - 1];
             pb.Image = a.LineTo(p1, p2, pb.Image, ts, Color.Red);
            vt++;
            if (vt > n - 2) vt = n - 2;
            btl_Truoc.Enabled = true;
        }

        private void btl_Truoc_Click(object sender, EventArgs e)
        {
            if (vt == 0) {  btl_Truoc.Enabled = false; }
            int ts = a.ToMaTrix[dd[vt] - 1, dd[vt+1] - 1];
            PointF p1 = a.ViTriVe[dd[vt] - 1];
            PointF p2 = a.ViTriVe[dd[vt+1] - 1];
            pb.Image = a.LineTo(p1, p2, pb.Image, ts, Color.Green);
            vt--;
            if (vt < 0) vt = 0;
            btl_Sau.Enabled = true;
        }
    }
}
