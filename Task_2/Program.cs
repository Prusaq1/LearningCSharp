internal class Program
{
    private static void Main(string[] args)      /*проверка года на высокосноть*/
    {
        int i;
        Console.Write("Введите год в формате YYYY:_");
        i = int.Parse(Console.ReadLine());

        if (i % 400 == 0 || i % 100 != 0 && i % 4 == 0)
        {
            Console.WriteLine($"Год {i} высокосный");
        }
        else if (i % 400 != 0 || i % 100 == 0 && i % 4 != 0)
        {
            Console.WriteLine($"Год {i} НЕ является высокосным");
        }      
    }
}