using System;
using static System.Console;

namespace TaskPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Point pt1 = new Point();
            Point pt2 = new Point(2, 3.5);

            Write("Объект pt1. ");
            pt1.Print();
            Write("Объект pt2. ");
            pt2.Print();

            WriteLine($"Static field Point.count = {Point.count}");

            Point[] ptArray = new Point[5];

            WriteLine($"Static field Point.count = {Point.count}");

            for (int i = 0; i < ptArray.Length; i++)
            {
                ptArray[i] = new Point(i, i * i);
            }
            WriteLine($"Static field Point.count = {Point.count}");
            WriteLine("Length between pt1 and pt2 is: {0:f3}", Point.LengthPoints(pt1, pt2));
        }
    }

    public class Point
    {
        public double x;
        public double y;

        public static int count;

        static Point()
        {
            count = 0;
        }

        public Point()
        {
            x = y = 1;
            count++;
        }
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
            count++;
        }

        public double GetX() { return x; }
        public double GetY() { return y; }
        public void SetX(double x) { this.x = x; }
        public void Set(double y) { this.y = y; }

        public void Print()
        {
            WriteLine("Fields of instance: ");
            WriteLine("x = {0}, y = {1}", x, y);
        }
        public static double LengthPoints(Point p1, Point p2)
        {
            double length;
            length = Math.Sqrt((p1.x - p2.x) * (p1.x - p2.x) + (p1.y - p2.y) * (p1.y - p2.y));
            return length;
        }
    }
}
    


