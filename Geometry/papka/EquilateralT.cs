using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometry
{
    internal class EquilateralT : AcuteT 
    {
        public EquilateralT(double a, double b, double c, int start_x, int start_y, int line_width, Color color)
        : base(a, b, c, start_x, start_y, line_width, color){  }
        public override double GetArea()
        {
            return (Math.Sqrt(3) * Math.Pow(A, 2)) / 4;
        }
        public override double GetPerimeter()
        {
            return A * 3;
        }
        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, Line_width);
            Point[] points = new Point[]
            {
                new Point(100, 0),
                new Point(0, 173),
                new Point(200, 173)
            };
            e.Graphics.DrawPolygon(pen, points);
        }

        public override void Info(PaintEventArgs e)
        {
            Console.WriteLine("\n\n\n\n\n\n\n\n");
            Console.WriteLine(GetType());
            Console.WriteLine($"Равносторонний треугольник");
            Console.WriteLine($"Длина сторон : {A}");
            base.Info(e);
        }
        public override void InfoT()
        {
            Console.WriteLine($"Равносторонний треугольник:{GetRaven()}");
            base.InfoT();
        }
       

        public bool GetRaven()
        {
            return A == B && B == C;
        }
        public override double GetHeight()
        {
            return (A * Math.Sqrt(3)) / 2;
        }
     
    }
}
