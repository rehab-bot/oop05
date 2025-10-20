using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop05
{
    internal class Rectangle : IRectangle
    {
        public double Area { get; set; }
        public Rectangle(double width, double height)
        {
            Area = width * height;
        }
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle Area: {Area}");
        }
    }
}
