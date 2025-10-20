namespace oop05
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Circle circle = new Circle(5);
            Rectangle rectangle = new Rectangle(4, 6);
            circle.DisplayShapeInfo();
            rectangle.DisplayShapeInfo();
        }
    }
}
