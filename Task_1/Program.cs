using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        int i, j;
        Console.Write("Введите число:");
        j = int.Parse(Console.ReadLine());

        for (i = 2; i * i <= j; i++)

            if (j % i == 0)
                Console.WriteLine($"Число {j} не является простым");
            else
            {
                Console.WriteLine($"Число {j} простое");
                break;
            }
    }
}