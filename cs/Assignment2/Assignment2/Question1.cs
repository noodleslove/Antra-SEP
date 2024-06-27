namespace Assignment2;

public static class Question1
{
    public static int[] GenerateNumbers()
    {
        return [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
    }

    public static void Reverse(int[] numbers)
    {
        int n = numbers.Length;
        for (int i = 0; i < n / 2; i++)
        {
            (numbers[i], numbers[n - i - 1]) = (numbers[n - i - 1], numbers[i]);
        }
    }

    public static void PrintNumbers(int[] numbers)
    {
        Console.WriteLine(String.Join(",", numbers));
    }
}