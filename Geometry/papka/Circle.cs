using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometry
{
    internal class Circle : Shape
    {
        double r;
        public double R
        {
            get=>r;
            
            set=> r = value < MIN_SIZE ? MIN_SIZE : value > MAX_SIZE ? MAX_SIZE: value;
 
        }

        public Circle(double r, int start_x, int start_y, int line_width, Color color) : base(start_x, start_y, line_width, color)
        {
            R = r;
        }
        public override double GetArea()
        {
            return Math.PI * R * R;
        }
        public override double GetPerimeter()
        {
            return 2 * Math.PI * R;
        }
        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, Line_width);
            e.Graphics.DrawEllipse(pen, start_x, start_y, (float)R*2, (float)R *2);
        }
        public override void Info(PaintEventArgs e)
        {
            Console.WriteLine($"Круг");
            Console.WriteLine($"Радиус: {R}");
            base.Info(e);
        }
    }
}
