using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETInterrogation_Console_App.Structure
{
    public struct Point1
    {
        /**
         * Create Readonly Data Members 
         * to mark them immutable
         */
        public readonly int x;
        public readonly int y;

        public Point1(int X, int Y)
        {
            x = X;
            y = Y;
        }

        // Method to calculate distance from another point
        public double DistanceTo(Point1 point)
        {
            int deltaX = x - point.x;
            int deltaY = y - point.y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
    }

    public struct Point2
    {
        public int x { get; set; }
        public int y { get; set; }

        // Method to calculate distance from another point
        public static double DistanceTo(Point2 point1, Point2 point2)
        {
            int deltaX = point1.x - point2.x;
            int deltaY = point1.y - point2.y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
    }

    public struct Rectangle
    {
        public int Length { get; set; }
        public int Width { get; set; }

        // Non-static method to calculate area
        public int CalculateArea()
        {
            return Length * Width;
        }

        // Static method to compare two rectangles
        public static bool AreEqual(Rectangle r1, Rectangle r2)
        {
            return r1.Length == r2.Length && r1.Width == r2.Width;
        }
    }
}
