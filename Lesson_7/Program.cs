namespace Lesson_7
{
    abstract static void Main();
    abstract class Animal
       {
           public abstract void Speak();
       }
    class Fish : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Буль-Bool");
        }
    }

}