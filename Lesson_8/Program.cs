namespace Lesson_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b, c;
                Console.WriteLine("Введите значение для a");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите значение для b");
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine("Результат: " + c);
            }
            catch (DivideByZeroException)
            { Console.WriteLine("Деление на ноль"); }
            catch (FormatException)
            { Console.WriteLine("Введить надо було число"); }
            finally
            {
                Console.WriteLine("Прювет");
            } 
        }
    }
}