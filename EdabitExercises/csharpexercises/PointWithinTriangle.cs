class PointWithinTriangle
{
    public static bool WithinTriangle(int[] p1, int[] p2, int[] p3, int[] test)
    {
        // Create points
        Point testPoint = new Point(test[0], test[1]);
        Point point1 = new Point(p1[0], p1[1]);
        Point point2 = new Point(p2[0], p2[1]);
        Point point3 = new Point(p3[0], p3[1]);

        // The idea is that for each line of triangle the test point
        // must be closer than the third point of the triangle.
        bool result = 
            CheckLineIntersections(point1, point2, point3, testPoint) &&
            CheckLineIntersections(point2, point3, point1, testPoint) &&
            CheckLineIntersections(point3, point1, point2, testPoint);

        return result;
    }

    private static bool CheckLineIntersections(Point p1, Point p2, Point p3, Point tp)
    {
        // Translate points so that (x1, y1) becomes the origin
        p2 -= p1;
        p3 -= p1;
        tp -= p1;

        // Calculate the angle between the line and the X-axis
        double angle = Math.Atan2(p2.y, p2.x);

        // Rotate points around the origin by -angle
        p2.Rotate(-angle);
        p3.Rotate(-angle);
        tp.Rotate(-angle);

        return tp.x == 0 || Math.Sign(tp.y) == Math.Sign(p3.y);
    }

    private struct Point
    {
        public double x, y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void Rotate(double angle)
        {
            double newX = x * Math.Cos(angle) - y * Math.Sin(angle);
            double newY = x * Math.Sin(angle) + y * Math.Cos(angle);

            x = newX;
            y = newY;
        }

        public static Point operator +(Point p1, Point p2)
        {
            double x = p1.x + p2.x;
            double y = p1.y + p2.y;
            return new Point(x, y);
        }

        public static Point operator -(Point p1, Point p2)
        {
            double x = p1.x - p2.x;
            double y = p1.y - p2.y;
            return new Point(x, y);
        }
    }
}