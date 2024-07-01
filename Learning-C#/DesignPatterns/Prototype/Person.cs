namespace DesignPatterns.Prototype
{
    public class Person
    {
        public int Age;
        public string? Name;
        public DateTime BirthDate;
        public IdInfo? IdInfo;

        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }

        public Person DeepCopy()
        {
            if (IdInfo is null)
            {
                throw new ArgumentNullException(nameof(IdInfo));
            }
            if (Name is null)
            {
                throw new ArgumentNullException(nameof(Name));
            }

            Person clone = (Person)this.MemberwiseClone();
            clone.IdInfo = new IdInfo(IdInfo.IdNumber);
            clone.Name = (string)Name.Clone();
            return clone;
        }
    }
}