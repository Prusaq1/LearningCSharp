namespace Lesson_7
{
    internal class Program
    {
        public static void Main()
        {
            Fish fish = new Fish();
            fish.Speak();
            fish.name = "Valera";
            Console.WriteLine(fish.name);
        }
    }
}
    