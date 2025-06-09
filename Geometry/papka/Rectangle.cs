using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometry
{
    internal class Rectangle : Shape
    {
        double a;
        double b;
        public double A
        {
            get => a;

            set => a = value < MIN_SIZE ? MIN_SIZE : value > MIN_SIZE ? MIN_SIZE : value;
            
        }
        public double B
        {
            get=> b;
            
            set=> b = value < MIN_SIZE ? MIN_SIZE : value > MIN_SIZE ? MIN_SIZE : value;
            
        }
        public Rectangle(double a, double b, int start_x, int start_y, int line_width, Color color) 
            : base(start_x, start_y, line_width, color)
        {
            A = a;
            B = b;
        }
        public override double GetArea()
        {
            return A * B;
        }
        public override double GetPerimeter()
        {
            return (A + B) * 2;
        }
        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, line_width);
            e.Graphics.DrawRectangle(pen, start_x, start_y, (float)A, (float)B);

            //IntPtr hwnd = GetConsoleWindow();
            //Graphics graphics = Graphics.FromHwnd(hwnd);
            //Rectangle window_rect = new Rectangle
            //    (
            //    Console.WindowLeft, Console.WindowTop,
            //    Console.WindowWidth, Console.WindowHeight
            //    );
            //PaintEventArgs e = new PaintEventArgs(graphics, window_rect);
            //e.Graphics.DrawRectangle(new Pen(Color, 3), 50, 100, 100, 50);
        }
        
        public override void Info(PaintEventArgs e)
        {
            Console.WriteLine(GetType());
            Console.WriteLine($"Прямоугольник");
            Console.WriteLine($"Длина стороны A: {A}, Длина стороны B: {B}");
            base.Info(e);
        }
    }
}
