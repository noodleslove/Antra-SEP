namespace Evaulation.Model
{
    public abstract class Person
    {
        public string Name { get; set; }
        public uint Age { get; set; }
        public Gender Gender { get; set; }

        public Person(string name, uint age)
        {
            Name = name;
            Age = age;
        }
    }
}