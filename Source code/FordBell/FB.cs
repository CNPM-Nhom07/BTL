﻿using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;
using System.Data;

namespace ployd
{
    class FB
    {
        #region  field

        const int vocung = 9999999;

        private int sodinh;
        private PointF[] dsve;
        private int[,] trongSo;
        private int[] Truoc;
        private int[] khoangcach;
        public int[] DuongDi;
        #endregion
        #region Contrustion
        public FB(string filename)
        {

            StreamReader doc = new StreamReader(filename);
            string tam = doc.ReadLine();
            tam = tam.Trim();
            sodinh = int.Parse(tam);
            dsve = new PointF[sodinh];
            trongSo = new int[sodinh, sodinh];
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
                    trongSo[i, l] = int.Parse(temp[l]);

                }
            }
            doc.Close();
            for (int i = 0; i < sodinh; i++)
            {
                for (int j = 0; j < sodinh; j++)
                {
                    if (trongSo[i, j] == 0)
                    {
                        trongSo[i, j] = vocung;
                    }
                }
            }

        }
        public FB(int sodinh, int[,] matran)
        {
            this.sodinh = sodinh;
            this.trongSo = matran;
            dsve = new PointF[sodinh];
            
            Truoc = new int[sodinh];
            khoangcach = new int[sodinh];
            DuongDi = new int[sodinh];
            for (int i = 0; i < sodinh; i++)
            {
                for (int j = 0; j < sodinh; j++)
                {
                    if (trongSo[i, j] == 0)
                    {
                        trongSo[i, j] = vocung;
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
                        if (danhdau[i] == 0 && trongSo[v, i] != vocung)
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
                    st += (trongSo[i, j]) + " ";
                }
                st += "\r\n";
            }
            return st;
        }

        public void Floyd(int Diem_dau)
        {

            for (int i = 0; i < sodinh; i++)
            {


                khoangcach[i] = trongSo[Diem_dau, i];


                Truoc[i] = Diem_dau;

            }


            for (int i = 0; i < sodinh - 2; i++)
            {

                for (int u = 0; u < sodinh; u++)
                {
                    for (int v = 0; v < sodinh; v++)
                    {
                        int tmp = khoangcach[u] + trongSo[u, v];
                        if (khoangcach[v] > tmp  && tmp !=vocung )                           
                        {
                            khoangcach[v] = tmp;
                            Truoc[v] = u;

                        }
                    }
                }

            }


        }
        public void Dijkstra(int bd, int kt)
        {
            int[] S = new int[11];
            // dat vo cung cho tat ca cap canh khong noi voi nhau
            for (int e = 0; e < sodinh; e++)
            {
                for (int j = 0; j < sodinh; j++)
                {
                    if (e != j && trongSo[e,j] == 0)
                        trongSo[e,j] = vocung;
                }
            }
            for (int e = 0; e < sodinh; e++)
            {
                KhoangCach[e] = vocung;                   // khoi tao do dai tu a toi moi dinh la vo cung
                S[e] = 0;   
                Truoc[e] = bd;                       // dat diem bat dau cua moi diem la a
            }
            int i;
            while (S[kt] == 0)
            {                 // trong khi diem cuoi chua duoc xet
                for ( i = 0; i < sodinh; i++)          // tim 1 vi tri ma khong phai la vo cung
                    if (S[i] == 0 && khoangcach[i] < vocung)
                        break;

                // i >=n tuc la duyet het cac dinh ma khong the tim thay dinh b -> thoat
                if (i >= sodinh )
                {
                    break;
                }

                for (int j = 0; j < sodinh; j++)
                {    // tim diem co vi tri ma do dai la min
                    if ( S[j] == 0  && khoangcach[i] > khoangcach[j])
                    {
                        i = j;
                    }
                }

                S[i] = 1;                       // cho i vao danh sach xet roi

                for (int j = 0; j < sodinh; j++)
                {    // tinh lai do dai cua cac diem chua xet
                    if (S[j] == 0  && khoangcach[i] + trongSo[i,j] < khoangcach[j])
                    {
                        khoangcach[j] = khoangcach[i] + trongSo[i,j];      // thay doi len
                        Truoc[j] = i;                       // danh dau diem truoc no
                    }
                }
            }


        }
        public void Bell_forman (int bd)
        {
            for (int i = 0; i < sodinh; i++)
            {


                khoangcach[i] = trongSo[bd, i];


                Truoc[i] = bd;

            }
          for (int i = 0; i < sodinh - 2; i++)
            {

                for (int u = 0; u < sodinh; u++)
                {
                    for (int v = 0; v < sodinh; v++)
                    {
                        int tmp = khoangcach[u] + trongSo[u, v];
                        if (khoangcach[v] > tmp && tmp != vocung)
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
            a = LineTo(dsve[kt], dsve[Truoc[kt]], a, trongSo[kt, Truoc[kt]], Color.Red);
            while (i != bd)
            {
                a = LineTo(dsve[i], new PointF(dsve[Truoc[i]].X, dsve[Truoc[i]].Y), a, trongSo[i , Truoc[i]], Color.Red);
                i = Truoc[i];
            }
            return a;
        }
        public void TimDuong(int bd, int kt)
        {
            int i, j = 0;
            DuongDi[j] = kt + 1;
            i = Truoc[kt];
            while (i != bd)
            {
                DuongDi[++j] = i + 1;


                i = Truoc[i];


            }
            DuongDi[j + 1] = bd + 1;

        }
        public string XuaKQ(int bd, int kt, Image anh)
        {
            Bitmap a = new Bitmap(anh);

           // Floyd(bd);
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
                    if (trongSo[i, j] != trongSo[j, i])
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
                    if (trongSo[i - 1, j - 1] != vocung)
                    {
                        
                            a = LineTo(dsve[i - 1], dsve[j - 1], a, trongSo[i - 1, j - 1], Color.Green);
                        


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
            get { return trongSo; }
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

