namespace ArraysAndStrings;

public class PracticeTypes
{
    // Practice number sizes and ranges question 1
    public static void Question1()
    {
        Console.WriteLine($"1. sbyte\n\t- Bytes in memory: {sizeof(sbyte)}\n\t- Minimum value: {sizeof(sbyte)}\n\t- Maximum value: {sbyte.MaxValue}");
        Console.WriteLine($"2. byte\n\t- Bytes in memory: {sizeof(byte)}\n\t- Minimum value: {byte.MinValue}\n\t- Maximum value: {byte.MaxValue}");
        Console.WriteLine($"3. short\n\t- Bytes in memory: {sizeof(short)}\n\t- Minimum value: {short.MinValue}\n\t- Maximum value: {short.MaxValue}");
        Console.WriteLine($"4. ushort\n\t- Bytes in memory: {sizeof(ushort)}\n\t- Minimum value: {ushort.MinValue}\n\t- Maximum value: {ushort.MaxValue}");
        Console.WriteLine($"5. int\n\t- Bytes in memory: {sizeof(int)}\n\t- Minimum value: {int.MinValue}\n\t- Maximum value: {int.MaxValue}");
        Console.WriteLine($"6. uint\n\t- Bytes in memory: {sizeof(uint)}\n\t- Minimum value: {uint.MinValue}\n\t- Maximum value: {uint.MaxValue}");
        Console.WriteLine($"7. long\n\t- Bytes in memory: {sizeof(long)}\n\t- Minimum value: {long.MinValue}\n\t- Maximum value: {long.MaxValue}");
        Console.WriteLine($"8. ulong\n\t- Bytes in memory: {sizeof(ulong)}\n\t- Minimum value: {ulong.MinValue}\n\t- Maximum value: {ulong.MaxValue}");
        Console.WriteLine($"9. float\n\t- Bytes in memory: {sizeof(float)}\n\t- Minimum value: {float.MinValue}\n\t- Maximum value: {float.MaxValue}");
        Console.WriteLine($"10. double\n\t- Bytes in memory: {sizeof(double)}\n\t- Minimum value: {double.MinValue}\n\t- Maximum value: {double.MaxValue}");
        Console.WriteLine($"11. decimal\n\t- Bytes in memory: {sizeof(decimal)}\n\t- Minimum value: {decimal.MinValue}\n\t- Maximum value: {decimal.MaxValue}");
    }
    
    // Practice number sizes and ranges question 2
    public static void Question2()
    {
        Console.Write("Input: ");

        ushort centuries = Convert.ToUInt16(Console.ReadLine());
        ushort years = Convert.ToUInt16(centuries * 100);
        ushort leapYears = Convert.ToUInt16(years / 4 - years / 100 + years / 400);
        uint days = Convert.ToUInt32(years * 365 + leapYears);
        uint hours = Convert.ToUInt32(days * 24);
        ulong minutes = Convert.ToUInt64(hours * 60);
        ulong seconds = Convert.ToUInt64(minutes * 60);
        ulong milliseconds = Convert.ToUInt64(seconds * 1000);
        ulong microseconds = Convert.ToUInt64(milliseconds * 1000);
        ulong nanoseconds = Convert.ToUInt64(microseconds * 1000);

        Console.Write($"Output: {centuries} centuries = {years} years");
        Console.Write($" = {days} days = {hours} hours = {minutes} minutes");
        Console.Write($" = {seconds} seconds = {milliseconds} milliseconds");
        Console.Write($" = {microseconds} microseconds = {nanoseconds} nanoseconds\n");
    }
}