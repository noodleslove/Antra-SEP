namespace Evaulation.Model
{
    public class Employee : Person
    {
        public string Company { get; set; }
        public string Position { get; set; }

        public Employee(string name, uint age, string company, string position) : base(name, age)
        {
            Company = company;
            Position = position;
        }
    }
}