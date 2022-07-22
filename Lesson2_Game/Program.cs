namespace ConsoleGame
{
    internal class ProgramBase
    {

        static readonly char[] XO = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1;
        static int choice;
        static int flag = 0; // Усли = 1 то ктото выиграл/ = -1 то Ничья/ 0 то играем
        public ProgramBase() { }
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();// Очистка экрана
                Console.WriteLine("Игрок 1:X and Игрок 2:O");
                Console.WriteLine("\n");
                if (player % 2 == 0)//Проверка очерёдности
                {
                    Console.WriteLine("Игрок 2 твой ход");
                }
                else
                {
                    Console.WriteLine("Игрок 1 твой ход");
                }
                Console.WriteLine("\n");
                Board();
                choice = int.Parse(Console.ReadLine());//Выбор пользователя
                                                       // проверка возможности хода (свободное поле)
                if (XO[choice] != 'X' && XO[choice] != 'O')
                {
                    if (player % 2 == 0) //Если ход игрока 2 то возвращается 0, иначе возвращается Х
                    {
                        XO[choice] = 'O';
                        player++;
                    }
                    else
                    {
                        XO[choice] = 'X';
                        player++;
                    }
                }
                else
                //Если занято, показать сообщение, изаново ждать ход
                {
                    Console.WriteLine("------ЗАНЯТО!------\nВыберите другое поле\n-----через 3 сек.-----");
                    Thread.Sleep(3000);
                }
                flag = CheckWin();
            }
            while (flag != 1 && flag != -1);            // Цикл заполнения всех полей
            Console.Clear();
            Board();// возврат заполненных полей
            if (flag == 1)
            // Если =1 последний ход выиграл
            {
                Console.WriteLine("Игрок {0} Выграл!", (player % 2) + 1);
            }
            else
            {
                Console.WriteLine("   Ничья");
            }
            Console.ReadLine();
        }
        private static void Board()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", XO[1], XO[2], XO[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", XO[4], XO[5], XO[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", XO[7], XO[8], XO[9]);
            Console.WriteLine("     |     |      ");
        }
        //проверка на выиграш
        private static int CheckWin()
        {
            //Условия выиграша рядов
            if (XO[1] == XO[2] && XO[2] == XO[3])
            {
                return 1;
            }
            else if (XO[4] == XO[5] && XO[5] == XO[6])
            {
                return 1;
            }
            else if (XO[6] == XO[7] && XO[7] == XO[8])
            {
                return 1;
            }
            else if (XO[1] == XO[4] && XO[4] == XO[7])
            {
                return 1;
            }
            else if (XO[2] == XO[5] && XO[5] == XO[8])
            {
                return 1;
            }
            else if (XO[3] == XO[6] && XO[6] == XO[9])
            {
                return 1;
            }
            else if (XO[1] == XO[5] && XO[5] == XO[9])
            {
                return 1;
            }
            else if (XO[3] == XO[5] && XO[5] == XO[7])
            {
                return 1;
            }

            else if (XO[1] != '1' && XO[2] != '2' && XO[3] != '3' && XO[4] != '4' && XO[5] != '5' && XO[6] != '6' && XO[7] != '7' && XO[8] != '8' && XO[9] != '9')
            {
                return -1; // Если все клетки заполнены то ничья
            }
            else
            {
                return 0;
            }
        }
    }
}