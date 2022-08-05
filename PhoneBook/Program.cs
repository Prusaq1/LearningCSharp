namespace PhoneBook
{
    class Program
    {
        private static int n = 4;
        private static int m = 5;
        private static List<string> phoneList = new List<string> ();

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("1.Создать запись\n2.Удалить запись\n3.Вывести на экран все записи телефонной книги\n4.Выход");
                Console.Write("Ведите команду: ");

                string i = Console.ReadLine();

                switch (i)
                {
                    case "1":
                        phoneNew();
                        break;
                    case "2":
                        phoneDelete();
                        break;
                    case "3":
                        phoneView();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Не верная команда. Попробуйте еще раз.\n");
                        break;
                }
            }
        }

        static void phoneNew()
        {
            Console.Clear();

            Console.Write("Ведите имя: ");
            string name = Console.ReadLine();
            Console.Write("Ведите номер телефона: ");
            string number = Console.ReadLine();

            try
            {
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < m; j++)
                        if (phoneList[i, j] == null)
                        {
                            phoneList[i, j] = string.Format("{0} {1}", name, number);
                            Console.WriteLine("Записанно!");
                            Console.WriteLine();
                            return;
                        }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        static void phoneDelete()
        {
            Console.Clear();
            Console.WriteLine("Список");

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    if (phoneList[i, j] != null)
                    {
                        int a = 1;
                        switch (i)
                        {
                            case 0:
                                a = j + a;
                                break;
                            case 1:
                                a = a + m + j;
                                break;
                            case 2:
                                a = a + (m * 2) + j;
                                break;
                            case 3:
                                a = a + (m * 3) + j;
                                break;
                        }
                        Console.WriteLine("{0}. {1}", a, phoneList[i, j]);
                    }

            try
            {
                Console.Write("Ведите номер удаляемого контакта: ");
                int index = Convert.ToInt32(Console.ReadLine()) - 1;

                int index1 = index / 4;

                switch (index)
                {
                    case 4:
                    case 8:
                    case 9:
                    case 12:
                    case 13:
                    case 14:
                    case 16:
                    case 17:
                    case 18:
                    case 19:
                        index1 = index1 - 1;
                        break;
                }

                int index2 = index;

                while (index2 > 4)
                {
                    index2 = index2 - 5;
                }

                phoneList[index1, index2] = null;
                Console.WriteLine("Удалено!");

                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        static void phoneView()
        {
            Console.Clear();
            int a = 1;
            Console.WriteLine("Список");
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    if (phoneList[i, j] != null)
                        Console.WriteLine("{0}. {1}", a++, phoneList[i, j]);

            Console.WriteLine();
        }
    }
}