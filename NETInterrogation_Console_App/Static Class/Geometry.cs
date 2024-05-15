namespace NETInterrogation_Console_App.Static_Class
{
    public static class Geometry
    {
        public static double CalculateCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        public static double CalculateRectangleArea(double length, double width)
        {
            return length * width;
        }

        public static double CalculateTriangleArea(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }
    }
}
