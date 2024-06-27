namespace Assignment2;

// Interface for common person-related methods
public interface IPersonService
{
    int CalculateAge(DateTime birthDate);
    decimal CalculateSalary();
    List<string> GetAddresses();
    void AddAddress(string address);
}

// Interface for student-specific methods
public interface IStudentService : IPersonService
{
    void EnrollInCourse(Course course);
    decimal CalculateGPA();
}

// Interface for instructor-specific methods
public interface IInstructorService : IPersonService
{
    void AssignDepartment(Department department);
    void SetHeadOfDepartment(bool isHead);
    int CalculateYearsOfExperience();
}

// Interface for course-related methods
public interface ICourseService
{
    void EnrollStudent(Student student);
    void AssignGrade(Student student, char grade);
    List<Student> GetStudents();
}

// Interface for department-related methods
public interface IDepartmentService
{
    void SetHead(Instructor instructor);
    void AddCourse(Course course);
}

// Abstract base class demonstrating Abstraction
public abstract class Person : IPersonService
{
    // Encapsulated fields with public properties
    private string name;
    private DateTime birthDate;
    private decimal salary;
    private List<string> addresses = new List<string>();

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public DateTime BirthDate
    {
        get { return birthDate; }
        set { birthDate = value; }
    }

    public decimal Salary
    {
        get { return salary; }
        set
        {
            if (value < 0) throw new ArgumentException("Salary cannot be negative.");
            salary = value;
        }
    }

    public Person(string name, DateTime birthDate, decimal salary)
    {
        Name = name;
        BirthDate = birthDate;
        Salary = salary;
    }

    public int CalculateAge(DateTime birthDate)
    {
        var age = DateTime.Now.Year - birthDate.Year;
        if (DateTime.Now.DayOfYear < birthDate.DayOfYear)
            age--;
        return age;
    }

    public virtual decimal CalculateSalary()
    {
        return Salary;
    }

    public List<string> GetAddresses()
    {
        return addresses;
    }

    public void AddAddress(string address)
    {
        addresses.Add(address);
    }

    public abstract void DisplayRole();
}

// Derived class for Student demonstrating Inheritance
public class Student : Person, IStudentService
{
    private List<Course> courses = new List<Course>();

    public Student(string name, DateTime birthDate, decimal salary) : base(name, birthDate, salary) { }

    public void EnrollInCourse(Course course)
    {
        courses.Add(course);
        course.EnrollStudent(this);
    }

    public decimal CalculateGPA()
    {
        int totalGrades = 0;
        int totalCourses = courses.Count;

        foreach (var course in courses)
        {
            totalGrades += course.GetGrade(this);
        }

        return totalCourses == 0 ? 0 : (decimal)totalGrades / totalCourses;
    }

    public override void DisplayRole()
    {
        Console.WriteLine("Role: Student");
    }

    public void Study()
    {
        Console.WriteLine("Study!");
    }
}

// Derived class for Instructor demonstrating Inheritance
public class Instructor : Person, IInstructorService
{
    private Department? _department;
    private bool _isHead;
    private DateTime _joinDate;

    public Instructor(string name, DateTime birthDate, decimal salary, DateTime joinDate)
        : base(name, birthDate, salary)
    {
        this._joinDate = joinDate;
    }

    public void AssignDepartment(Department department)
    {
        this._department = department;
    }

    public void SetHeadOfDepartment(bool isHead)
    {
        this._isHead = isHead;
    }

    public int CalculateYearsOfExperience()
    {
        return DateTime.Now.Year - _joinDate.Year;
    }

    public override decimal CalculateSalary()
    {
        decimal bonus = CalculateYearsOfExperience() * 1000;
        return base.CalculateSalary() + bonus;
    }

    public override void DisplayRole()
    {
        Console.WriteLine("Role: Instructor");
        if (_department != null)
        {
            Console.WriteLine("Head of Department: " + _department.Name);
        }
    }

    public void Teach()
    {
        Console.WriteLine("Teach!");
    }
}

// Class for Course
public class Course : ICourseService
{
    public string Name { get; set; }
    private Dictionary<Student, char> enrolledStudents = new Dictionary<Student, char>();

    public Course(string name)
    {
        Name = name;
    }
    
    public List<Student> GetStudents()
    {
        return enrolledStudents.Keys.ToList();
    }

    public void EnrollStudent(Student student)
    {
        if (!enrolledStudents.ContainsKey(student))
        {
            enrolledStudents.Add(student, 'F'); // Default grade
        }
    }

    public void AssignGrade(Student student, char grade)
    {
        if (enrolledStudents.ContainsKey(student))
        {
            enrolledStudents[student] = grade;
        }
    }

    public int GetGrade(Student student)
    {
        if (enrolledStudents.TryGetValue(student, out char grade))
        {
            return GradeToPoint(grade);
        }
        return 0;
    }

    private int GradeToPoint(char grade)
    {
        return grade switch
        {
            'A' => 4,
            'B' => 3,
            'C' => 2,
            'D' => 1,
            'F' => 0,
            _ => 0,
        };
    }
}

// Class for Department
public class Department : IDepartmentService
{
    public string Name { get; set; }
    public Instructor Head { get; private set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal Budget { get; set; }
    private List<Course> courses = new List<Course>();

    public Department(string name, DateTime startDate, DateTime endDate, decimal budget)
    {
        Name = name;
        StartDate = startDate;
        EndDate = endDate;
        Budget = budget;
    }

    public void SetHead(Instructor instructor)
    {
        Head = instructor;
        instructor.SetHeadOfDepartment(true);
    }

    public void AddCourse(Course course)
    {
        courses.Add(course);
    }

    public List<Course> GetCourses()
    {
        return courses;
    }
}