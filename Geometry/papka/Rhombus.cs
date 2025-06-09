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
    //internal class Rhombus : Shape
    //{
    //    double a;
    //    double d1;
    //    double d2;
    //    public double A
    //    {
    //        get
    //        {
    //            return a;
    //        }
    //        set
    //        {
    //            a = value;
    //        }
    //    }
    //    public double D1
    //    {
    //        get
    //        {
    //            return d1;
    //        }
    //        set
    //        {
    //            d1 = value;
    //        }
    //    }
    //    public double D2
    //    {
    //        get
    //        {
    //            return d2;
    //        }
    //        set
    //        {
    //            d2 = value;
    //        }
    //    }
    //    public Rhombus(double a, double d1, double d2, Color color) : base(color)
    //    {
    //        A = a;
    //        D1 = d1;
    //        D2 = d2;
    //    }
    //    public override double GetArea()
    //    {
    //        return D1 * D2 / 2;
    //    }
    //    public override double GetPerimeter()
    //    {
    //        return A * 4;
    //    }
    //    public override void Draw()
    //    {
    //        IntPtr hwnd = GetConsoleWindow();
    //        Graphics graphics = Graphics.FromHwnd(hwnd);
    //        Rectangle window_rect = new Rectangle
    //        (
    //            Console.WindowLeft, Console.WindowTop,
    //            Console.WindowWidth, Console.WindowHeight
    //        );
    //        PaintEventArgs e = new PaintEventArgs(graphics, window_rect);
    //        Point[] points = new Point[]
    //        {
    //        new Point(180, 120),
    //        new Point(300, 200),
    //        new Point(180, 280),
    //        new Point(60, 200)

    //        };
    //        e.Graphics.DrawPolygon(new Pen(Color, 3), points);
    //    }
    //    [DllImport("kernel32.dll")]
    //    public static extern IntPtr GetConsoleWindow();
    //    [DllImport("kernel32.dll")]
    //    public static extern IntPtr GetDC(IntPtr hwnd);
    //    public override void Info()
    //    {
    //        Console.WriteLine($"Ромб");
    //        Console.WriteLine($"Длина стороны A: {A}, Диагональ D1: {D1}, Диагональ D2: {D2}");
    //        base.Info();
    //    }
    }
