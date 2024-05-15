namespace NETInterrogation_Console_App.Shallow_Deep_Copy
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Shallow copy method
        public Person ShallowCopy()
        {
            return (Person)MemberwiseClone();
        }

        // Deep copy method
        public Person DeepCopy()
        {
            return new Person(Name, Age);
        }

    }
}
