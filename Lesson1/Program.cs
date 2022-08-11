using System.Drawing;

namespace Lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Arrov = { "0", "1", "2", "3", "4", "5", "6", "7", "8" };

            for (int i = 0; i < 9; i++)
            {
                if (i % 2 == 0)
                {

                    NewMethod(Arrov);
                    Console.WriteLine("Игрок 1 выбери ход");
                    int j = Convert.ToInt32(Console.ReadLine());
                    Arrov[j] = "x";

                }
                else
                {
                    NewMethod(Arrov);
                    Console.WriteLine("Игрок 2 выбери ход");

                    int j = Convert.ToInt32(Console.ReadLine());
                    Arrov[j] = "O";
                }
            }
        }
        private static void NewMethod(string[] Arrov)
        {
            Console.WriteLine("-------------");
            for     (int i = 0; i< 9; i=i+3)
            {
                Console.WriteLine(Arrov[i] + " |  " + Arrov[i + 1] + " |  " + Arrov[i + 2]);
                Console.WriteLine("-------------");

            }
    }
}


                
        }
                
            /*Console.WriteLine(Arrov[3] + " |  " + Arrov[4] + " |  " + Arrov[5]);
            Console.WriteLine("-------------------");
            Console.WriteLine(Arrov[6] + " |  " + Arrov[7] + " |  " + Arrov[8]);
            Console.WriteLine("-------------------");
            Console.ForegroundColor = ConsoleColor.Green;*/



            //TopLevel.Color color = TopLevel.Color.Red;




/*if (Arrov[i] == "x")
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(Arrov[i]);
    Console.ResetColor();
    Console.Write(" |  " + Arrov[i + 1] + " |  " + Arrov[i + 2]);
    if (Arrov[i + 1] == "x")
    {
        Console.WriteLine(Arrov[i] + " |  ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(Arrov[i + 1]);
        Console.ResetColor();
        Console.Write(" |  " + Arrov[i + 2]);
        if (Arrov[i + 2] == "x")
        {
            Console.WriteLine(Arrov[i] + " |  " + Arrov[i + 1] + " | ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(Arrov[i + 2]);
            Console.ResetColor();

        }

    }

}

else
{
    Console.WriteLine(Arrov[i] + " |  " + Arrov[i + 1] + " |  " + Arrov[i + 2]);
}*/