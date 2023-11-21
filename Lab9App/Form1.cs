using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab9App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(Form1_Paint);
            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Circle circle = new Circle(50, 50, 40);
            Square square = new Square(150, 50, 50);
            Rectangle rectangle = new Rectangle(250, 50, 60, 30);

            circle.Draw(e.Graphics);
            square.Draw(e.Graphics);
            rectangle.Draw(e.Graphics);
        }
    }

    public abstract class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Shape(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public abstract void Draw(Graphics g);
        public void Move(int deltaX, int deltaY)
        {
            X += deltaX;
            Y += deltaY;
        }
        public void Resize(int newWidth, int newHeight)
        {
            Width = newWidth;
            Height = newHeight;
        }
        public abstract void Rotate(float angle);
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
    }

    public class Circle : Shape
    {
        public Circle(int x, int y, int radius) : base(x, y, radius * 2, radius * 2)
        {
        }

        public override void Draw(Graphics g)
        {
            g.DrawEllipse(Pens.Black, X, Y, Width, Height);
        }

        public override void Rotate(float angle)
        {
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Width / 2.0, 2);
        }

        public override double CalculatePerimeter()
        {
            return Math.PI * Width;
        }
    }

    public class Square : Shape
    {
        public Square(int x, int y, int sideLength) : base(x, y, sideLength, sideLength)
        {
        }

        public override void Draw(Graphics g)
        {
            g.DrawRectangle(Pens.Black, X, Y, Width, Height);
        }

        public override void Rotate(float angle)
        {

        }

        public override double CalculateArea()
        {
            return Math.Pow(Width, 2);
        }

        public override double CalculatePerimeter()
        {
            return 4 * Width;
        }
    }

    public class Rectangle : Shape
    {
        public Rectangle(int x, int y, int width, int height) : base(x, y, width, height)
        {
        }

        public override void Draw(Graphics g)
        {
            g.DrawRectangle(Pens.Black, X, Y, Width, Height);
        }

        public override void Rotate(float angle)
        {

        }

        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (Width + Height);
        }
    }
}
