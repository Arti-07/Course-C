using System;

namespace Упр3
{
    class Program
    {
        public enum vyz { КГУ, КАИ, КХТИ, КФУ, МГУ }
        struct rabotnik
        {
            public string name;
            public string vus;
            public string secondname;
            public int zp;
        }

        static void Main(string[] args)
        {
            vyz novi = vyz.КФУ;
            rabotnik kiko;
            kiko.name = "Володя";
            kiko.secondname = "Ибрагимов";
            kiko.vus = Convert.ToString(novi);
            kiko.zp = 1000;
            Console.WriteLine(kiko.name);
            Console.WriteLine(kiko.vus);
            Console.WriteLine(kiko.zp);
            Console.WriteLine(kiko.secondname);
            Console.ReadLine();

        }
    }
}
