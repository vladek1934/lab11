using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int x; int y;
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawStar( 225, 225, 50, 50);
            DrawMine(155, 155);
            DrawStar(45, 355, 25, 25);
            DrawMine(455, 455);
            DrawStar(325, 225, 50, 50);
            DrawMine(555, 155);
            DrawStar(555, 375, 25, 25);
            DrawMine(665, 385);
            Drawship(250, 500);
            Drawbullet(240, 340);
        }

        public void DrawStar(int x, int y, int x2, int y2)
        {
            HatchBrush hBrush = new HatchBrush(
         HatchStyle.DottedDiamond,
         Color.Black,
         Color.LightGoldenrodYellow);
           
            g.FillEllipse(hBrush, x, y, x2, y2);
        }


        public void DrawMine(int x, int y)
        {
            HatchBrush hBrush = new HatchBrush(
         HatchStyle.DiagonalBrick,
         Color.Red,
         Color.Black);
              PointF point1 = new PointF(x-30, y); 
              PointF point2 = new PointF(x - 45, y -35);
              PointF point3 = new PointF(x  -10, y - 35);
              PointF point4 = new PointF(x +20, y - 75);
              PointF point5 = new PointF(x +50, y-35);
              PointF point6 = new PointF(x + 85, y - 35);
              PointF point7 = new PointF(x + 70, y );
              PointF point8 = new PointF(x - 30, y);
              PointF point9 = new PointF(x - 45, y + 35);
              PointF point10 = new PointF(x - 10, y + 35);
              PointF point11 = new PointF(x + 20, y + 75);
              PointF point12 = new PointF(x + 50, y + 35);
              PointF point13 = new PointF(x + 85, y + 35);
              PointF point14 = new PointF(x + 70, y);

              PointF[] curvePoints = { point1, point2, point3, point4, point5, point6, point7,point8, point9, point10, point11, point12, point13, point14,  };
               FillMode newFillMode = FillMode.Winding;

               g.FillPolygon(hBrush, curvePoints, newFillMode);
        }


        public void Drawship(int x, int y)
        {
            Brush brush = new SolidBrush(Color.Blue);
            PointF point1 = new PointF(x - 20, y-30);
            PointF point2 = new PointF(x - 45, y - 30);
            PointF point3 = new PointF(x , y - 65);
            PointF point4 = new PointF(x + 45, y - 30);
            PointF point5 = new PointF(x + 20, y - 30);
            PointF point6 = new PointF(x + 20, y + 65);
            PointF point7 = new PointF(x-20, y+65);
            PointF point8 = new PointF(x - 20, y - 30);

            Brush bru = new SolidBrush(Color.Yellow);
            PointF point10 = new PointF(x - 60, y - 40);
            PointF point11 = new PointF(x , y - 80);
            PointF point12 = new PointF(x+60, y - 40);
            PointF point13 = new PointF(x +60, y +40);
            PointF point14 = new PointF(x , y +80);
            PointF point15 = new PointF(x - 60, y +40);

            PointF[] curvePoints = { point1, point2, point3, point4, point5, point6, point7, point8};
            FillMode newFillMode = FillMode.Winding;
            PointF[] curvePoint = { point10, point11, point12, point13, point14, point15};
            g.FillPolygon(bru, curvePoint, newFillMode);
            g.FillPolygon(brush, curvePoints, newFillMode);
       
        }

        public void Drawbullet(int x, int y)
        {
            Brush brush = new SolidBrush(Color.Cyan);
            PointF point1 = new PointF(x - 10, y - 10);
            PointF point2 = new PointF(x , y - 35);
            PointF point3 = new PointF(x + 10, y - 10);
            PointF point4 = new PointF(x + 35, y );
            PointF point5 = new PointF(x + 10, y + 10);
            PointF point6 = new PointF(x , y + 35);
            PointF point7 = new PointF(x - 10, y + 10);
            PointF point8 = new PointF(x -35, y);


            PointF[] curvePoints = { point1, point2, point3, point4, point5, point6, point7, point8 };
            FillMode newFillMode = FillMode.Winding;

            g.FillPolygon(brush, curvePoints, newFillMode);
        }
        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            int x = this.PointToClient(Cursor.Position).X;
            int y = this.PointToClient(Cursor.Position).Y;
            DrawStar(x-25 , y-25, 50,50);
            DrawMine(x - 55, y - 55);
        }

    }
}
