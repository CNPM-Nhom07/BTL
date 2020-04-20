using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;
using System.Data;

namespace FordBell
{
    class FB
    {
        #region  field

        const int vocung = 9999999;

        private int sodinh;
        private PointF[] dsve;
        private int[,] matrantrongso;
        private int[] Truoc;
        private int[] khoangcach;
        private int[] DuongDi;
        #endregion
        #region Contrustion
        public FB(string filename)
        {

            StreamReader doc = new StreamReader(filename);
            string tam = doc.ReadLine();
            tam = tam.Trim();
            sodinh = int.Parse(tam);
            dsve = new PointF[sodinh];
            matrantrongso = new int[sodinh, sodinh];
            Truoc = new int[sodinh];
            khoangcach = new int[sodinh];
            DuongDi = new int[sodinh];
            for (int i = 0; i < sodinh; i++)
            {
                tam = doc.ReadLine();
                tam = tam.TrimStart();
                tam = tam.TrimEnd();
                string[] temp = new string[sodinh];
                int k = 0;

                for (int j = 0; j < tam.Length; j++)
                {
                    if (tam[j] != ' ')
                    {
                        temp[k] += tam[j];

                    }
                    else
                    {
                        k++;
                    }
                }

                for (int l = 0; l < sodinh; l++)
                {
                    matrantrongso[i, l] = int.Parse(temp[l]);

                }
            }
            doc.Close();
            for (int i = 0; i < sodinh; i++)
            {
                for (int j = 0; j < sodinh; j++)
                {
                    if (matrantrongso[i, j] == 0)
                    {
                        matrantrongso[i, j] = vocung;
                    }
                }
            }

        }
        public FB(int sodinh, int[,] matran)
        {
            this.sodinh = sodinh;
            this.matrantrongso = matran;
            dsve = new PointF[sodinh];
            
            Truoc = new int[sodinh];
            khoangcach = new int[sodinh];
            DuongDi = new int[sodinh];
            for (int i = 0; i < sodinh; i++)
            {
                for (int j = 0; j < sodinh; j++)
                {
                    if (matrantrongso[i, j] == 0)
                    {
                        matrantrongso[i, j] = vocung;
                    }
                }
            }
        }
#endregion
        #region  method

      
        public bool DFS(int s)
        {

            int[] danhdau = new int[sodinh];
            int[] dinhlienthong = new int[sodinh];
            int sodinhlienthong = 0;



            for (int i = 0; i < SoDinh; i++)
            {
                danhdau[i] = 0;
            }

            Stack<int> st = new Stack<int>();
            st.Push(s);

            while (st.Count != 0)
            {
                int v = st.Pop();

                if (danhdau[v] != 1)
                {


                    dinhlienthong[sodinhlienthong++] = v;

                    danhdau[v] = 1;
                    for (int i = sodinh - 1; i >= 0; i--)
                    {
                        if (danhdau[i] == 0 && matrantrongso[v, i] != vocung)
                        {
                            st.Push(i);

                        }
                    }
                }
            }
            Array.Resize(ref dinhlienthong, sodinhlienthong);
            if (sodinhlienthong == sodinh)
                return true;
            return false;



        }

        public override string ToString()
        {
            string st = "";
            for (int i = 1; i <= sodinh; i++)
            {
                for (int j = 1; j <= sodinh; j++)
                {
                    st += (matrantrongso[i, j]) + " ";
                }
                st += "\r\n";
            }
            return st;
        }

        public void bellmanFord(int Diem_dau)
        {


            for (int i = 0; i < sodinh; i++)
            {


                khoangcach[i] = matrantrongso[Diem_dau, i];


                Truoc[i] = Diem_dau;

            }


            for (int i = 0; i < sodinh - 2; i++)
            {

                for (int u = 0; u < sodinh; u++)
                {
                    for (int v = 0; v < sodinh; v++)
                    {
                        int tmp = khoangcach[u] + matrantrongso[u, v];
                        if (khoangcach[v] > tmp  && tmp !=vocung )                           // THay doi dau > thành <
                        {
                            khoangcach[v] = tmp;
                            Truoc[v] = u;

                        }
                    }
                }

            }


        }
        public Bitmap DuongDiPic(int bd, int kt,Image anh)
        {
            Bitmap a = new Bitmap(anh);
            int i = Truoc[kt];
            a = LineTo(dsve[kt], dsve[Truoc[kt]], a, matrantrongso[kt, Truoc[kt]], Color.Red);
            while (i != bd)
            {
                a = LineTo(dsve[i], new PointF(dsve[Truoc[i]].X, dsve[Truoc[i]].Y), a, matrantrongso[i , Truoc[i]], Color.Red);
                i = Truoc[i];
            }
            return a;
        }
        public string XuaKQ(int bd, int kt, Image anh)
        {
            Bitmap a = new Bitmap(anh);

            bellmanFord(bd);
            if (khoangcach[kt]==vocung)
            {
                return  "Không có đường đi từ " + (bd+1) + " đến " + (kt+1);
            }
            int i, j = 0;
            string st = "";
          
            DuongDi[j] = kt + 1;
            if (bd == kt)
            {
                return "Bạn đang ở đó ùi nek !!!! :D:D";
            }

            i = Truoc[kt];
            while (i != bd)
            {
                DuongDi[++j] = i + 1;
                

                i = Truoc[i];


            }
            DuongDi[j + 1] = bd + 1;
            for (int k = j + 1; k >= 0; k--)
            {
                if (k == j + 1)
                    st += DuongDi[k];
                else
                    st += " -> " + DuongDi[k];
            }

            
            
            return st;
        }
        public bool KiemTraVoHuong()
        {

            for (int i = 0; i < sodinh; i++)
            {
                for (int j = 0; j < sodinh; j++)
                {
                    if (matrantrongso[i, j] != matrantrongso[j, i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }


        #endregion
        #region Display
        public Bitmap Paint()
        {
            Bitmap kq = new Bitmap(900, 450);
            int top=sodinh/2;
            if(sodinh==1)
            {
                top = sodinh;
            }


            int vtbd = 900 / (top * 2);
            for (int i = 1; i <= top; i++)
            {
                if (i % 2 != 0)
                {
                    kq = DrawNode(i.ToString(), vtbd + (i - 1) * 900 / (top), 20, kq, Color.Red);
                    dsve[i - 1] = new PointF(vtbd + (i - 1) * 900 / (float)((top)), 20);
                }
                else
                {
                    kq = DrawNode(i.ToString(), vtbd + (i - 1) * 900 / (top), 100, kq, Color.Red);
                    dsve[i - 1] = new PointF(vtbd + (i - 1) * 900 / (float)((top)), 100);
                }

            }

            int khoangcach = sodinh - top;

            for (int i = 1; i <= sodinh - top; i++)
            {
                if (i % 2 != 0)
                {
                    kq = DrawNode((i + top).ToString(), (i - 1) * 900 / (khoangcach), 300, kq, Color.Red);
                    dsve[i - 1 + top] = new PointF((i - 1) * 900 / (float)((khoangcach)), 300);
                }
                else
                {
                    kq = DrawNode((i + top).ToString(), (i - 1) * 900 / (khoangcach), 380, kq, Color.Red);
                    dsve[i - 1 + top] = new PointF((i - 1) * 900 / (float)((khoangcach)), 380);
                }

            }



            kq = Line(kq);
            return kq;
        }

        public Bitmap Line(Bitmap a)
        {

            for (int i = 1; i <= sodinh; i++)
            {
                for (int j = 1; j <= sodinh; j++)
                {
                    if (matrantrongso[i - 1, j - 1] != vocung)
                    {
                        
                            a = LineTo(dsve[i - 1], dsve[j - 1], a, matrantrongso[i - 1, j - 1], Color.Green);
                        


                    }
                }
            }


            return a;
        }

        public  Bitmap LineTo(PointF p1, PointF p2, Image ima, int k, Color mau)
        {
            Bitmap kq;

            if (ima != null)
            {
                kq = new Bitmap(ima);
            }
            else
            {
                kq = new Bitmap(900, 400);
            }


            System.Drawing.Graphics graphicsObj;



            graphicsObj = Graphics.FromImage(kq);

            Pen myPen = new Pen(mau, 4);



            graphicsObj.DrawLine(myPen, p1, p2);

            Brush myBrush = new SolidBrush(Color.Black);
            Font myFont = new System.Drawing.Font("Verdana", 14, FontStyle.Regular);
            graphicsObj.DrawString(k.ToString(), myFont, myBrush, new PointF((p1.X + p2.X) / 2, (p1.Y + p2.Y) / 2 - 20));


            return kq;
        }

        public  Bitmap DrawNode(string st, float x, float y, Image ima, Color cl)
        {


            Bitmap kq;

            if (ima != null)
            {
                kq = new Bitmap(ima);
            }
            else
            {
                kq = new Bitmap(992, 438);
            }


            System.Drawing.Graphics graphicsObj;



            graphicsObj = Graphics.FromImage(kq);

            Pen myPen = new Pen(Color.Green, 2);


            Font myFont = new System.Drawing.Font("Verdana", 17, FontStyle.Regular);

            Brush myBrush = new SolidBrush(cl);

            graphicsObj.DrawString(st, myFont, myBrush, x + 5, y - 6);


            return kq;

        }
        #endregion

        #region property
        public int SoDinh
        {
            get { return sodinh; }
        }
        public int[,] ToMaTrix
        {
            get { return matrantrongso; }
        }
        public int[] KhoangCach
        {
            get { return khoangcach; }
        }
        public PointF[] ViTriVe
        {
            get { return dsve; }
        }
#endregion
        
    }
}

