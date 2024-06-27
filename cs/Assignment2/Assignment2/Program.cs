// See https://aka.ms/new-console-template for more information

using Assignment2;

void TestQuestion6()
{
    // Create instances
    Student student = new Student("Alice", new DateTime(2000, 5, 15), 0);
    Instructor instructor = new Instructor("Dr. Smith", new DateTime(1975, 3, 10), 75000, new DateTime(2005, 8, 1));

    Course course1 = new Course("Mathematics");
    Course course2 = new Course("Physics");

    student.EnrollInCourse(course1);
    student.EnrollInCourse(course2);

    course1.AssignGrade(student, 'A');
    course2.AssignGrade(student, 'B');

    Department department = new Department("Science", new DateTime(2023, 9, 1), new DateTime(2024, 6, 30), 500000);
    department.SetHead(instructor);
    department.AddCourse(course1);
    department.AddCourse(course2);

    // Demonstrating Encapsulation, Abstraction, Inheritance, and Polymorphism
    List<IPersonService> people = new List<IPersonService> { student, instructor };

    foreach (var person in people)
    {
        if (person is Student s)
        {
            s.DisplayRole();
            Console.WriteLine("GPA: " + s.CalculateGPA());
        }
        else if (person is Instructor i)
        {
            i.DisplayRole();
            Console.WriteLine("Experience: " + i.CalculateYearsOfExperience() + " years");
        }
        Console.WriteLine("Salary: " + person.CalculateSalary());
        Console.WriteLine();
    }

    // Demonstrating specific behavior for each type
    student.Study();
    instructor.Teach();
}

void TestQuestion7()
{
    // Create a few Color instances
    Color redColor = new Color(255, 0, 0);
    Color greenColor = new Color(0, 255, 0);
    Color blueColor = new Color(0, 0, 255);

    // Create a few Ball instances
    Ball redBall = new Ball(10, redColor);
    Ball greenBall = new Ball(15, greenColor);
    Ball blueBall = new Ball(20, blueColor);

    // Throw the balls around a few times
    redBall.Throw();
    redBall.Throw();
    greenBall.Throw();
    blueBall.Throw();
    blueBall.Throw();
    blueBall.Throw();

    // Pop a few balls
    redBall.Pop();
    greenBall.Pop();

    // Try to throw the popped balls again
    redBall.Throw();
    greenBall.Throw();

    // Print out the number of times the balls have been thrown
    Console.WriteLine("Red ball throw count: " + redBall.GetThrowCount());
    Console.WriteLine("Green ball throw count: " + greenBall.GetThrowCount());
    Console.WriteLine("Blue ball throw count: " + blueBall.GetThrowCount());
}

int[] numbers = Question1.GenerateNumbers();
Question1.Reverse(numbers);
Question1.PrintNumbers(numbers);

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(Question2.Fibonacci(i));
}

TestQuestion6();

TestQuestion7();