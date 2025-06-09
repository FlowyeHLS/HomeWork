using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Geometry
{
    abstract class Shape
    {
        static readonly int MIN_START_X = 100;
        static readonly int MAX_START_X = 1000;
        static readonly int MIN_START_Y = 50;
        static readonly int MAX_START_Y = 800;

        static readonly int MIN_LINE_VALUE = 0;
        static readonly int MAX_LINE_VALUE = 10;

        protected static readonly int MIN_SIZE = 50;
        protected static readonly int MAX_SIZE = 850;



        public int start_x;
        public int start_y;
        public int line_width;
        public int startX
        {
            get => start_x;
            set => start_x = value < MIN_START_X ? MIN_START_X : value > MAX_START_X ? MAX_START_X : value;
        }
        public int startY
        {
            get => start_y;
            set => start_y = value < MIN_START_Y ? MIN_START_Y : value > MAX_START_Y ? MAX_START_Y : value;
        }
        public int Line_width
        {
            get => line_width;
            set => line_width = value < MIN_LINE_VALUE ? MIN_LINE_VALUE : value > MAX_LINE_VALUE ? MAX_LINE_VALUE : value;
        }
        public Color Color { get; set; }
       public Shape(int start_x, int start_y, int line_width, Color color)
        {
            this.start_x = start_x;
            this.start_y = start_y;
            this.line_width = line_width;
            Color = color;
        }
        public abstract double GetArea();
        public abstract double GetPerimeter();
        public abstract void Draw(PaintEventArgs e);
        public virtual void Info(PaintEventArgs e)
        {
            Console.WriteLine($"Площадь фигуры: {GetArea()}");
            Console.WriteLine($"Периметр фигуры:{GetPerimeter()}");
            Draw(e);
        }
    }
}
