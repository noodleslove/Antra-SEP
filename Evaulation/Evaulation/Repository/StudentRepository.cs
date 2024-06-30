using Evaulation.Model;

namespace Evaulation.Repository
{
    public class StudentRepository : IRepository<Student>
    {
        List<Student> _students = new List<Student>
        {
            new Student("John", 20, "UCSD", "Freshman"),
            new Student("Jane", 21, "UCLA", "Junior"),
            new Student("Jack", 22, "USC", "Senior"),
            new Student("Jill", 23, "Columbia", "Graduate"),
            new Student("James", 24, "NYU", "Graduate"),
        };

        public List<Student> GetAll()
        {
            return _students;
        }

        public List<Student> Search(Predicate<Student> predicate)
        {
            return _students.FindAll(predicate);
        }
    }
}