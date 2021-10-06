using System;

namespace Ep013_OPP_Delegates
{
    public class Rectangle
    {
        // two methods
        public void GetArea(decimal width, decimal height)
        {
            var result = width * height;
            Console.WriteLine($"Area of the rectangle: width: {width} * height: {height} = {result}");
        }

        public void GetPerimeter(decimal width, decimal height)
        {
            var result = 2 * (width + height);
            Console.WriteLine($"Perimeter: {result}");
        }
    }
}
