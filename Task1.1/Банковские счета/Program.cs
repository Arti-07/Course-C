using System;

namespace Банковские_счета
{
    class Program
    {
        public enum schet {Текущий, Кредитный, Депозитный, Бюджетный, Для_соц_выплат}
       
        static void Main(string[] args)
        {
            schet MyShet = new schet();
            MyShet = schet.Депозитный;
            Console.WriteLine(MyShet);
            Console.ReadLine();
        }
    }
}
