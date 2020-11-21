using System;

namespace lab_8_1
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Введите значение для первого поля: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string theFirst = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Gray;


                Console.Write("Введите значение для второго поля: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string theSecond = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Gray;


                Indexers newindexer = new Indexers(theFirst, theSecond);
                Console.WriteLine();


                Console.Write("Введите индекс (0 и 1 - вывод значений поля): ");
                int index = int.Parse(Console.ReadLine());


                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(newindexer[index]);
                Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
