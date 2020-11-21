using System;

namespace lab_8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateIndexer newDate = new DateIndexer();
            Console.Write("Вы хотите ввести свою дату или использовать дату компьютера? (1 - своя, 2 - компьютера)\n-> ");
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            int choice = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Gray;

            if (choice == 1)
            {
                int day, month, year;
                do
                {
                    Console.Write("Введите день: ");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    day = int.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Gray;

                    if (day <= 0 || day > 31)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("В месяце до 31 дня. Повторите попытку");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                }
                while (day <= 0 || day > 31);

                do
                {
                    Console.Write("Введите месяц: ");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    month = int.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Gray;

                    if (month <= 0 || month > 12)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("В году 12 месяцев. Повторите попытку");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                }
                while (month <= 0 || month > 12);

                do
                {
                    Console.Write("Введите год: ");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    year = int.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Gray;

                    if (year < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("К сожалению, работаем только с нашей эрой. Повторите попытку");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                }
                while (year < 0);

                newDate = new DateIndexer(day, month, year);
            }
            else if (choice ==2 )
            {
                newDate = new DateIndexer(Convert.ToInt32(DateTime.Today.Day), Convert.ToInt32(DateTime.Today.Month), Convert.ToInt32(DateTime.Today.Year));

                Console.WriteLine($"\nЗадействована следующая дата: {(DateTime.Today).ToShortDateString()}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Неизвестное действие");
                Console.ForegroundColor = ConsoleColor.Gray;

                Environment.Exit(0);
            }
            
            Console.Write("\nВведите любой индекс: ");

            Console.ForegroundColor = ConsoleColor.Cyan;
            int index = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\nПолученная дата: {newDate[index].ToShortDateString()}");
            Console.ForegroundColor = ConsoleColor.Gray;

        }
    }
}
