using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometry
{
    internal class AcuteT : Triangle
    {
        public AcuteT(double a, double b, double c, int start_x, int start_y, int line_width, Color color)
   : base(start_x, start_y, line_width, color) { }
        public override double GetArea()
        {
            double p = (2 * A + B) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
        public override double GetPerimeter()
        {
            return A + B + C;
        }
        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, Line_width);
            Point[] points = new Point[]
            {
                new Point(100, 20),
                new Point(30, 150),
                new Point(170, 150)
            };

            e.Graphics.DrawPolygon(pen, points);
        }

        public override void Info(PaintEventArgs e)
        {
            Console.WriteLine("\n\n\n\n\n\n\n\n\n");
            Console.WriteLine(GetType());
            Console.WriteLine($"Остроугольный треугольник");
            Console.WriteLine($"Длина сторон А : {A}, Длина сторон B:{B}, Длина сторон C : {C}");
            base.Info(e);
        }

        public override void InfoT()
        {
            Console.WriteLine($"Остроугольный треугольник:{GetRav()}");
            base.InfoT();
        }

        public bool GetRav()
        {
            return Math.Pow(C, 2) < Math.Pow(A, 2) + Math.Pow(B, 2);
        }

        public override double GetHeight()
        {
            return 2 * GetArea() / A;
        }
    }
}
