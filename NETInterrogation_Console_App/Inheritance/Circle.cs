namespace NETInterrogation_Console_App.Inheritance
{
    public class Circle: Feature
    {
        private double Radius { get; set; }
        private readonly double Pi = Math.PI;

        public Circle(string name, double radius): base(name) 
        {
            Radius = radius;
        }

        public override void GetArea()
        {
            base.GetArea();
            Console.WriteLine($"Area: {Pi*Radius*Radius}");
        }

        public override void GetCircumference()
        {
            base.GetCircumference();
            Console.WriteLine($"Circumference: {2 * Pi * Radius}");
        }
    }
}
