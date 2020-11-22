using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nПривет! Как тебя зовут?  ");
            string name = Console.ReadLine();
            Console.WriteLine("\nДоброго времени суток, " + name);


            Console.WriteLine("\nПривет! Введи два числа.");
            Console.Write("\n 1st = ");
            string str = Console.ReadLine();
            int k;
            bool chislo1 = int.TryParse(str, out k);
            if (chislo1) { }
            else
            {
                Console.WriteLine("\nНекорректное значение!");
                return;
            }
            Console.Write("\n 2nd = ");
            string str2 = Console.ReadLine();
            int l;
            bool chislo2 = int.TryParse(str2, out l);
            if (chislo2) { }
            else
            {
                Console.WriteLine("\nНекорректное значение!");
                return;
            }
            if (l != 0)
            {
                double n = k * 1.0 / l;
                Console.WriteLine("\nРезультат деления первого числа на второе =  " + n);
                Console.ReadLine();
            }
            else
                Console.WriteLine("ОШИБКА! ДЕЛЕНИЕ НА 0 ");
            
        }
    }
}
