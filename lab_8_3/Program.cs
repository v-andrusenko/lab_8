using System;

namespace lab_8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            CharClass charClass = new CharClass(11);
            IntClass intClass = new IntClass(11);
            for (int i=0; i<11;i++)
            {
                intClass[i] = i;
                Console.WriteLine(intClass[i]);
            }
            charClass['.'] = '0';

            Console.WriteLine(charClass['.']);
            
            Console.WriteLine(charClass.arrayLength[0] + "     " + charClass.arrayLength[1]);
            Console.ReadLine();
        }
    }
}
