using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop05
{
    internal class Circle : ICircle
    {
        public double Area { get; set; }
        public Circle(double radius)
        {
            Area = Math.PI * radius * radius;
        }
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle Area: {Area}");
        }
    }
}
