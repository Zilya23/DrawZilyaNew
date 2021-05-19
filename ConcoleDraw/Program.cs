using System;

namespace ConcoleDraw
{
    class Program
    {
        static void Main(string[] args)
        {

            using System;

class Program
        {
            static void Main()
            {
                Dot II = new Circle(2, 1, 4);
                II.Draw();
            }
        }

        public class Dot
        {
            protected int x;
            protected int y;

            public Dot(int newX, int newY)
            {
                x = newX;
                y = newY;
            }
            public virtual void Draw()
            { }
        }

        public class Line : Dot
        {
            protected int x1;
            protected int y1;

            public Line(int newX, int newY, int newX1, int newY1) : base(newX, newY)
            {
                x1 = newX1;
                y1 = newY1;
            }

            public override void Draw()
            {
                Console.WriteLine("Я линия с началом на (" + x + ", " + y + ") и концом на (" + x1 + ", " + y1 + ")");
            }
        }

        public class Circle : Dot
        {
            protected int r;

            public Circle(int newX, int newY, int newR) : base(newX, newY)
            {
                r = newR;
            }

            public override void Draw()
            {
                Console.WriteLine("Я окружность с центром в точке (" + x + ", " + y + ") и радиусом = " + r);
            }
        }

        public class Rectangle : Dot
        {
            protected int h;
            protected int l;

            public Rectangle(int newX, int newY, int newH, int newL) : base(newX, newY)
            {
                h = newH;
                l = newL;
            }

            public override void Draw()
            {
                Console.WriteLine("Я прямоугольник с углом в точке (" + x + ", " + y + ") и шириной, длинной = " + h + l);
            }
        }

        public class Triangle : Dot
        {
            protected int x1;
            protected int y1;
            protected int x2;
            protected int y2;

            public Triangle(int newX, int newY, int newX1, int newY1, int newX2, int newY2) : base(newX, newY)
            {
                x1 = newX1;
                y1 = newY1;
                x2 = newX2;
                y2 = newY2;
            }

            public override void Draw()
            {
                Console.WriteLine("Я треугольник с вершиной в точке (" + x + ", " + y + ") второй вершиной = ( " + x1 + ", " + y1 + " )  и третьей вершиной в = " + x2 + ", " + y2);
            }
        }
    }
    }
}
