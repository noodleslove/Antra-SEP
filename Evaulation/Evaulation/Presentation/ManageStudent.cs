using Evaulation.Model;
using Evaulation.Repository;

namespace Evaulation.Presentation
{
    public class ManageStudent
    {
        private IRepository<Student> _studentRepository = new StudentRepository();

        public void SelectDemo()
        {
            var result = _studentRepository.GetAll().Select(student => student.Name);

            Console.WriteLine(string.Join(", ", result));
        }

        public void WhereDemo()
        {
            var result = _studentRepository.GetAll().Where(student => student.Age > 21);

            foreach (var student in result)
            {
                Console.WriteLine($"{student.Name}\t|{student.Age}\t|{student.School}\t|{student.Grade}");
            }
        }

        public void OrderByDemo()
        {
            var result = _studentRepository
                .GetAll()
                .OrderByDescending(student => student.Age)
                .ThenBy(student => student.Name);

            foreach (var student in result)
            {
                Console.WriteLine($"{student.Name}\t|{student.Age}\t|{student.School}\t|{student.Grade}");
            }
        }

        public void GroupByDemo()
        {
            var result = _studentRepository
                .GetAll()
                .GroupBy(student => student.School);

            foreach (var group in result)
            {
                Console.WriteLine(group.Key);
                foreach (var student in group)
                {
                    Console.WriteLine($"\t{student.Name}\t|{student.Age}\t|{student.School}\t|{student.Grade}");
                }
            }
        }

        public void Run()
        {
            Console.WriteLine("Select Demo");
            SelectDemo();

            Console.WriteLine("Where Demo");
            WhereDemo();

            Console.WriteLine("OrderBy Demo");
            OrderByDemo();

            Console.WriteLine("GroupBy Demo");
            GroupByDemo();
        }
    }
}