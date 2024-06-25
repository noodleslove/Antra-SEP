namespace ArraysAndStrings;

public class PracticeLoops
{
    // Practice loops and operators question 1
    public static void Question1()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("fizzbuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
    
    // Practice loops and operators question 2
    public static void Question2()
    {
        string output = "";

        for (int i = 0; i < 5; i++)
        {
            output += new string(' ', 4 - i);
            output += new string('*', 1 + i * 2);
            output += new string(' ', 4 - i);
            output += '\n';
        }

        Console.Write(output);
    }
    
    // Practice loops and operators question 3
    public static void Question3()
    {
        int correctNumber = new Random().Next(3) + 1;

        Console.Write("Make a guess: ");
        int guessNumber = int.Parse(Console.ReadLine());

        if (guessNumber < 1 || 3 < guessNumber)
        {
            Console.WriteLine("Please enter a valid number between 1 and 3");
        }
        else if (guessNumber < correctNumber)
        {
            Console.WriteLine("Guess higher");
        }
        else if (guessNumber > correctNumber)
        {
            Console.WriteLine("Guess lower");
        }
        else
        {
            Console.WriteLine("You guess it right!");
        }
    }

    // Practice loops and operators question 4
    public static void Question4()
    {
        DateTime birthDate = new DateTime(1985, 3, 30);
        DateTime now = DateTime.Now;

        TimeSpan age = now - birthDate;

        Console.WriteLine($"This person is {age.Days} days old.");

        int daysToNextAnniversary = 10000 - (age.Days % 10000);

        Console.WriteLine($"Next 10,000 day anniversary is in {daysToNextAnniversary} days.");
    }

    // Practice loops and operators question 5
    public static void Question5()
    {
        DateTime now = DateTime.Now;

        if (now.Hour is >= 6 and <= 12)
        {
            Console.WriteLine("Good Morning");
        }
        else if (now.Hour is > 12 and <= 18)
        {
            Console.WriteLine("Good Afternoon");
        }
        else if (now.Hour is > 18 and <= 20)
        {
            Console.WriteLine("Good Evening");
        }
        else
        {
            Console.WriteLine("Good Night");
        }
    }

    // Practice loops and operators question 6
    public static void Question6()
    {
        for (int i = 1; i < 5; i++)
        {
            for (int j = 0; j < 25; j += i)
            {
                Console.Write(j);
                if (j < 24)
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine();
        }
    }
}