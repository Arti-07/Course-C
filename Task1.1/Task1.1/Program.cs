using System;

namespace Task1._1
{
    class Program
    {
        public static bool Solve(double a, double b, double c, out double x1, out double x2)
        {
            x1 = 0; x2 = 0;
            double d = b * b - 4 * a * c;
            if (d < 0) return false;
            if (a == 0 && b == 0) return false;
            if (a == 0)
            {
                x1 = -c / b;
                x2 = -c / b;
            }
            else
            {
                x1 = (-b - Math.Sqrt(d)) / (2 * a);
                x2 = (-b + Math.Sqrt(d)) / (2 * a);
            }
            return true;

            static void Main(string[] args)
        {
            //
            // 1 задание
            //
            Console.Write("\nПривет! Как тебя зовут?  ");
            string name = Console.ReadLine();
            Console.WriteLine("\nДоброго времени суток, " + name);
            //
            //
            //
            //     2 задание
            //    

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

                //
                //  4 задание 
                //

                double x1, x2;
                if (Solve(1, -4, 4, out x1, out x2))
                    Console.WriteLine($"x1={x1}, x2={x2}");
                else Console.WriteLine("Решений нет");

                double a = 1, b = 7, c = 15;
                if (Solve(a, b, c, out x1, out x2))
                    Console.WriteLine($"x1={x1}, x2={x2}");
                else Console.WriteLine("Решений нет");

                Solve(0, 2, 5, out x1, out x2);
                Console.WriteLine($"x1={x1}, x2={x2}");

            }
    }
}
