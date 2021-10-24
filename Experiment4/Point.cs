using System;

namespace CSharp.Experiemnt4
{
    class Point
    {
        private double _x;
        public double x { get => _x; private set => _x = value; }
        private double _y;
        public double y { get => _y; private set => _y = value; }

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double Distance(Point p)
        {
            return Math.Sqrt(Math.Pow((p.x - this.x), 2) +
                             Math.Pow((p.y - this.y), 2));
        }

    }
}