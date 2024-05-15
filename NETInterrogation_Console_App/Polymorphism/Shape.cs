namespace NETInterrogation_Console_App.Polymorphism
{
    public abstract class Shape
    {
        public abstract string Name { get; set; }
        public virtual double Area()
        {
            return 0;
        }

        public virtual double Area(string name)
        {
            Console.WriteLine(name);
            return 0;
        }
    }
}
