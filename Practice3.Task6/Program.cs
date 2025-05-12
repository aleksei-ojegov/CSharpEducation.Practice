namespace Practice3.Task6
{
    struct Point
    {
        public int X;
        public int Y;
    }

    class Start
    {
        static void distance(Point p1, Point p2)
        {
            double x1 = (double)p1.X;
            double x2 = (double)p2.X;
            double y1 = (double)p1.Y;
            double y2 = (double)p2.Y;

            double dist = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            dist = Math.Round(dist, 2);
            Console.WriteLine($"Distance = {dist}");
        }

        static void Main()
        {
            Point point1 = new Point();
            Console.WriteLine("X :");
            point1.X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y :");
            point1.Y = Convert.ToInt32(Console.ReadLine());

            Point point2 = new Point();
            Console.WriteLine("X :");
            point2.X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y :");
            point2.Y = Convert.ToInt32(Console.ReadLine());

            distance(point1, point2);
        }
    }
}
