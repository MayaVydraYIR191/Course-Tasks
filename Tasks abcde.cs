using System;

namespace ConsoleApp38
{
    class Program
    {
        static void Main(string[] args)
        {
            const int integ = 5;
            const double dou = 3.5;
            bool bolean = false;
            decimal dec;
            string str = "string";
            float flo = 3.4f;
            char cha = 'r';

            int number = 6;
            long litnum = number;

            int n = 12;
            float fn = n;

            float f = 13.4f;
            double ddd = f;

            long lon = 1232313;
            double dlon = lon;

            short sh = 3;
            int ish = sh;

            double dddr = 12.4;
            decimal dddd;
            dddd = (decimal)dddr;

            int it = 3;
            short sit;
            sit = (short)it;

            long log = 4;
            short slog;
            slog = (short)log;

            float ft = 14.5f;
            decimal dt;
            dt = (decimal)ft;

            double d = 14.53;
            int r;
            r = (int)d;

            var var = 10;
            var = 12;
            var = 5;
           //const var var = 11;
            // Неявно типизированные переменные не могут быть константными
            //Локальная переменная или функция с именем "var" уже определена в этой области.
            int a = 100;
            object obj = 100;
            a = Convert.ToInt32(obj);
        }
    }
}
