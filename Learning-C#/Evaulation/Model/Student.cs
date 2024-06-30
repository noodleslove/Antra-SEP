namespace Evaulation.Model
{
    public class Student : Person
    {
        public string School { get; set; }
        public string Grade { get; set; }

        public Student(string name, uint age, string school, string grade) : base(name, age)
        {
            School = school;
            Grade = grade;
        }
    }
}