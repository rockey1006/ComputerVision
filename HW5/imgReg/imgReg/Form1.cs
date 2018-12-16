using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imgReg
{
    public partial class Form1 : Form
    {
        List<Point> Shape1 = new List<Point>();
        List<Point> Shape2 = new List<Point>();
        List<Point> Shape2Transformed = new List<Point>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInitializeShapes_Click(object sender, EventArgs e)
        {
            Shape1.Clear();
            Shape2.Clear();
            Point p1a = new Point(20, 30);
            Point p2a = new Point(120, 50);
            Point p3a = new Point(160, 80);
            Point p4a = new Point(180, 300);
            Point p5a = new Point(100, 220);
            Point p6a = new Point(50, 280);
            Point p7a = new Point(20, 140);
            Shape1.Add(p1a); Shape1.Add(p2a);
            Shape1.Add(p3a); Shape1.Add(p4a);
            Shape1.Add(p5a); Shape1.Add(p6a);
            Shape1.Add(p7a);
            Transformation T2 = new Transformation();
            T2.A = 1.05; T2.B = 0.05; T2.T1 = 15; T2.T2 = 22;
            Shape2 = ApplyTransformation(T2, Shape1);
            Shape2[2] = new Point(Shape2[2].X + 10, Shape2[2].Y + 3);// change one point

            // add outliers to both shapes
            Point ptOutlier1 = new Point(200, 230);
            Shape1.Add(ptOutlier1);
            Point ptOutLier2 = new Point(270, 160);
            Shape2.Add(ptOutLier2);


            Pen pBlue = new Pen(Brushes.Blue, 1);
            Pen pRed = new Pen(Brushes.Red, 1);
            Graphics g = panShape1.CreateGraphics();
            DisplayShape(Shape1, pBlue, g);
            DisplayShape(Shape2, pRed, g);

        }

        private void btnApplyTransformation_Click(object sender, EventArgs e)
        {
            Transformation T = ICPTransformation.ComputeTransformation(Shape1, Shape2);
            MessageBox.Show("Cost = " + ICPTransformation.ComputeCost(Shape1, Shape2,T).ToString());
            List<Point> Shape2T = ApplyTransformation(T, Shape2);
            Pen pBlue = new Pen(Brushes.Blue, 1);
            Pen pRed = new Pen(Brushes.Red, 1);
            Graphics g = panShape2.CreateGraphics();
            DisplayShape(Shape1, pBlue, g);
            DisplayShape(Shape2T, pRed, g);
        }

        void DisplayShape(List<Point> Shp, Pen pen, Graphics g)
        {
            Point? prevPoint = null; // nullable
            foreach (Point pt in Shp)
            {
                g.DrawEllipse(pen, new Rectangle(pt.X - 2, pt.Y - 2, 4, 4));
                if (prevPoint != null)
                    g.DrawLine(pen, (Point)prevPoint, pt);
                prevPoint = pt;
            }
            g.DrawLine(pen, Shp[0], Shp[Shp.Count - 1]);
        }

        List<Point> ApplyTransformation(Transformation T, List<Point> shpList)
        {
            List<Point> TList = new List<Point>();
            foreach (Point pt in shpList)
            {
                double xprime = T.A * pt.X + T.B * pt.Y + T.T1;
                double yprime = T.B * pt.X * -1 + T.A * pt.Y + T.T2;
                Point pTrans = new Point((int)xprime, (int)yprime);
                TList.Add(pTrans);
            }
            return TList;
        }
    
        private void btnOutlierRemoval_Click(object sender, EventArgs e)
        {
            Transformation T = ICPTransformation.ComputeTransformation(Shape1, Shape2);
            double Cost =  ICPTransformation.ComputeCost(Shape1, Shape2, T);
            List<Point> Shape2T = ApplyTransformation(T, Shape2);

            ComputeModel(Shape1, Shape2T);

            Transformation T2 = ICPTransformation.ComputeTransformation(Shape1, Shape2T);
            double Cost2 = ICPTransformation.ComputeCost(Shape1, Shape2T, T2);
            MessageBox.Show("Cost = " + Cost2.ToString());
            List<Point> Shape2T2 = ApplyTransformation(T2, Shape2T);

            Pen pBlue = new Pen(Brushes.Blue, 1);
            Pen pRed = new Pen(Brushes.Red, 1);
            Graphics g = panShape3.CreateGraphics();
            DisplayShape(Shape1, pBlue, g);
            DisplayShape(Shape2T2, pRed, g);

        }

        public static double ComputeModel(List<Point> P1List, List<Point> P2List)
        {
            double th = 0;
            double err = 0;
            int[] best = new int[P1List.Count];

            for (int k = 0; k < 50; k++)
            {
                for (int i = 0; i < P1List.Count; i++)
                {
                    double distance = Math.Sqrt((P1List[i].X - P2List[i].X) * (P1List[i].X - P2List[i].X) + (P1List[i].Y - P2List[i].Y) * (P1List[i].Y - P2List[i].Y));
                    th += distance / P1List.Count;

                }
                for (int i = 0; i < P1List.Count; i++)
                {
                    double distance = Math.Sqrt((P1List[i].X - P2List[i].X) * (P1List[i].X - P2List[i].X) + (P1List[i].Y - P2List[i].Y) * (P1List[i].Y - P2List[i].Y));
                    err = (distance - th) * (distance - th) / P1List.Count;
                    if (distance > (Math.Sqrt((th * th + th * P1List.Count))) - (th / P1List.Count))
                         best[i] = 0;
                    else best[i] = 1;

                }
                for (int i = 0; i < P1List.Count; i++)
                {
                    if (best[i] == 0)
                    {
                        P1List.RemoveAt(i);
                        P2List.RemoveAt(i);
                    }
                }
            }

            return err;
        }





    }
}
