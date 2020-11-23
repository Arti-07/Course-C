using System;

namespace Следующий_символ
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ConsoleKey key = Console.ReadKey().Key;
                int keykode = (int)key;
                Console.WriteLine();
                Console.WriteLine("Следующий символ " + key + 1);
            }
        }
    }
}
