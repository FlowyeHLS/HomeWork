using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Drawing.Printing;

namespace Geometry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WindowWidth = 200;
            Console.WindowHeight = 50;
            IntPtr hwnd = GetConsoleWindow();
            Graphics graphics = Graphics.FromHwnd(hwnd);
            System.Drawing.Rectangle window_rect = new System.Drawing.Rectangle
                 (
                 Console.WindowLeft, Console.WindowTop,
                 Console.WindowWidth, Console.WindowHeight
                 );
            PaintEventArgs e = new PaintEventArgs(graphics, window_rect);

            Triangle[] triangle_group = new Triangle[]
            {
                new EquilateralT(75, 75, 75, 80, 50, 5, Color.Pink),
           new IsoscelesT(100, 100, 80, 80, 50, 5, Color.Yellow),
            new RectangularT(30, 40, 50, 80, 50, 5, Color.Red),
            new AcuteT(60, 50, 40, 80, 50, 5, Color.Blue),
            new ObtuseT(40, 30, 70, 80, 50, 5, Color.Green)
        };

            Random rand = new Random();
            int randomIndex = rand.Next(triangle_group.Length);
            Triangle randomShape = triangle_group[randomIndex];
            Console.WriteLine("Рандомная фигура:");
            randomShape.Info(e);
            randomShape.InfoT();
            Console.ReadLine();
        }
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetConsoleWindow();
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetDC(IntPtr hwnd);
    }
}
