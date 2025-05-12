namespace Practice3.Task8
{
    struct Rectangle
    {
        public double width;
        public double height;

        public double Square()
        {
            return width * height;
        }
    }

    class Start
    {
        static void Main()
        {
            Rectangle point1 = new Rectangle();
            Console.WriteLine("Width :");
            point1.width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Height :");
            point1.height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Square = {point1.Square()}");
        }
    }
}
