using System;

namespace lab_8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            CharClass charClass = new CharClass();
            IntClass intClass = new IntClass();

            for (int i=0; i<26;i++)
            {
                intClass[i] = i;
            }

            charClass.fillArray();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Размер числового массива: {charClass.arrayLength[0]}\n" +
                $"Размер символьного массива: {charClass.arrayLength[1]}");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("значение числового = значение символьного");
            Console.ForegroundColor = ConsoleColor.Gray;

            for (int i=0; i<26;i++)
            {
                Console.WriteLine($"{intClass[i]} = {charClass[(char)i]}");
            }
            Console.ReadLine();
        }
    }
}
