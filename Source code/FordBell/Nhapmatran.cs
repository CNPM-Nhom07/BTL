using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace FordBell
{
    public partial class Nhapmatran : Form
    {
        public Nhapmatran()
        {
            InitializeComponent();
        }
        public int[,] mt;
        public  int sdinh;
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sdinh = Convert.ToInt32(sodinh.Text);
                if (sdinh <= 1)
                {
                    MessageBox.Show("Bạn phải nhập từ 2 đỉnh trở lên !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(sdinh>10)
                {
                    MessageBox.Show("Bạn chỉ được nhập tối đa 10 đỉnh !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    button1.Enabled = false;
                    sodinh.Enabled = false;

                    mt = new int[sdinh, sdinh];
                    dd.Items.Clear();
                    dc.Items.Clear();
                    for (int i = 1; i <= sdinh; i++)
                    {
                        dd.Items.Add(i);
                        dc.Items.Add(i);
                    }
                    dd.Enabled = dc.Enabled =button3.Enabled=button2.Enabled=button5.Enabled=button6.Enabled= true;

                }

            }


            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int dinhdau = int.Parse(dd.Text);
            int dinhcuoi = int.Parse(dc.Text);
            int ts = int.Parse(trongso.Text);
            if (dinhcuoi==dinhdau)
            {
                MessageBox.Show("Dữ liệu không hợp lệ");
            }
            else
            mt[dinhdau-1, dinhcuoi-1] = mt[dinhcuoi-1, dinhdau-1] = ts;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tam.matran = mt;
            tam.sodinh = sdinh;
            
            this.Close();
            
        }
        void ToListView()
        {
            dt.Columns.Clear();
            dt.Rows.Clear();
            int wid = dt.Width / sdinh;
            int hei = dt.Height / sdinh;
            for (int i = 1; i <= sdinh; i++)
            {
                dt.Columns.Add(i.ToString(), i.ToString());
                dt.Columns[i - 1].Width = wid;
            }


            for (int i = 0; i < sdinh; i++)
            {
                dt.Rows.Add();
                dt.Rows[i].Height = hei;

                for (int j = 0; j < sdinh; j++)
                {
                    if (mt[i, j] == 0 && i != j)
                    {
                        dt[j, i].Value = "∞";
                    }
                    else
                        dt[j, i].Value = mt[i, j];
                }
            }

        }


        private void Nhapmatran_Load(object sender, EventArgs e)
        {

        }

        private void dt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dd.Text = (e.RowIndex + 1).ToString();
            dc.Text = (e.ColumnIndex + 1).ToString();

            trongso.Text = mt[e.RowIndex, e.ColumnIndex].ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

            private void button6_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int[,] danhdau = new int[sdinh, sdinh];
            for (int i = 0; i < sdinh;i++)
            {
                for (int j = 0; j < sdinh; j ++)
                {
                    
                    if (i!=j && danhdau[i,j]==0)
                    {
                        mt[i, j] = mt[j, i] = rand.Next(10);
                        danhdau[i, j] = danhdau[j, i] = 1;
                    }
                }
            }
            ToListView();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ToListView();
        }
    }
}
