using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Code.InheritanceAndPolymorphism
{
    public class Class1
    {
        public void Area(int side) // for square
        {
            int area = side * side;
            Console.WriteLine("Area of square is: " + area);
        }

        public void Area(int length, int breadth) // for rectangle
        {
            int area = length * breadth;
            Console.WriteLine("Area of square is: " + area);
        }

        public void Area(int side1, int side2, int side3) // for triangle
        {
            double s = (side1 + side2 + side3) / 2;
            double area = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3)); // heron's formula
            Console.WriteLine("Area of square is: " + area);
        }

        public void Display()
        {
            Console.WriteLine("This is display() in parent class");
        }
    }
}
