using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using Cl1;

class Provodnic
{
    static string log;
    static string parol;
    static void Main()
    {
        Console.WriteLine("  Вход в систему");
        Console.WriteLine("  Логин:");
        Console.WriteLine("  Пароль:");
        Console.WriteLine("  Авторизация");

        while (true)
        {

            int pos = Menu.Show(1, 3);

            if (pos == 1)
            {
                Console.SetCursorPosition(9, 1);
                string log = Console.ReadLine();
            }

            if (pos == 2)
            {
                Console.SetCursorPosition(10, 2);
                string parol = "";
                ConsoleKeyInfo key;

                do
                {
                    key = Console.ReadKey(true);

                    // Проверяем, была ли нажата клавиша Backspace
                    if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                    {
                        parol += key.KeyChar;
                        Console.Write("*");
                    }
                    else
                    {
                        if (key.Key == ConsoleKey.Backspace && parol.Length > 0)
                        {
                            parol = parol.Substring(0, (parol.Length - 1));
                            Console.Write("\b \b");
                        }
                    }
                }
                while (key.Key != ConsoleKey.Enter);
            }

            if (pos == 3)
            {
                //проверка логина и пароля
                if (log == userlog)
                {
                    if (parol == userlogparol)
                    {

                        break;
                    }
                    else
                    {
                        Console.WriteLine("Неверный пароль");
                    }
                }

                else
                {
                    Console.WriteLine("Неверный логин");
                }
            }
        }
    }
}