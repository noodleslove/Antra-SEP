namespace ArraysAndStrings;

public static class PracticeArrays
{
    // Practice arrays question 1
    public static void Question1()
    {
        int[] arr = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        int[] arr2 = new int[arr.Length];

        for (int i = 0; i < arr2.Length; i++)
        {
            arr2[i] = arr[i];
        }

        Console.WriteLine(String.Join(",", arr2));
    }

    // Practice arrays question 2
    public static void Question2()
    {
        List<string> grocery = new List<string>();

        while (true)
        {
            Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
            string[] input = Console.ReadLine().Split();

            switch (input[0])
            {
                case "+":
                    grocery.Add(input[1]);
                    break;
                case "-":
                    grocery.Remove(input[1]);
                    break;
                case "--":
                    grocery.Clear();
                    break;
                case "x":
                    return;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
            
            Console.WriteLine("==== Grocery list ====");
            Console.WriteLine(String.Join("\n", grocery));
        }
    }

    // Practice arrays question 3
    public static int[] FindPrimesInRange(int startNum, int endNum)
    {
        List<int> output = new List<int>();
        for (int i = startNum; i <= endNum; i++)
        {
            bool isPrime = true;
            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                output.Add(i);
            }
        }

        return output.ToArray();
    }

    // Practice arrays question 4
    public static void Question4()
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int k = int.Parse(Console.ReadLine());
        int n = input.Length;

        int[] sum = new int[n];
        for (int i = 1; i <= k; i++)
        {
            for (int j = 0; j < n; j++)
            {
                sum[(i + j) % n] += input[j];
            }
        }

        Console.WriteLine(String.Join(" ", sum));
    }
}