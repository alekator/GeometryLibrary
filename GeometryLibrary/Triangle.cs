using System;
using System.Linq;

namespace GeometryLibrary
{
    public class Triangle : IShape
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new ArgumentException("The sides must be positive numbers.");

            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
                throw new ArgumentException("The sum of any two sides must be greater than the third party.");

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double GetArea()
        {
            double s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        public bool IsRightAngled()
        {
            var sides = new[] { SideA, SideB, SideC }.OrderBy(side => side).ToArray();
            double a = sides[0], b = sides[1], c = sides[2];
            return Math.Abs(c * c - (a * a + b * b)) < 1e-10;
        }
    }
}
