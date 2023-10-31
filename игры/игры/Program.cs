using System.Net.Http.Json;
using System.Numerics;
using System.Text.Json.Serialization;

namespace игры
{
    internal class Programm
    {
        public static int CaseS;
        static void Main()
        {
            Start();
            CaseS = int.Parse(Console.ReadLine());

            SelectedCase(CaseS);
        }

        public static void Start()
        {
            Console.WriteLine("Меню игр\n" +
                "1. Игра Угадай число\n" +
                "2. Таблица умножения\n" +
                "3. Вывод делителей числа\n"+
                "4. Выход!\n"+
                "Введите действие");
        }

        public static void SelectedCase(int id)
        {

            switch (id)
            {
                case 1:
                    StartGameUgadayka();
                    break;
                case 2:
                    PrintTable();
                    break;
                case 3:
                    MathFunction();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Такого действия нет!");
                    break;
            }
        }


        public static void StartGameUgadayka()
        {
            try
            {
                int r = new Random().Next(0, 100);
                int c;
                Console.WriteLine("Угадай число от 0 до 100");
                Console.WriteLine("Введите число:");
                do
                {
                    c = int.Parse(Console.ReadLine());
                    if (c < r) Console.WriteLine("Число больше!!!!!");
                    if (c > r) Console.WriteLine("Число меньше!!!!!");
                }
                while (c != r);

                Console.WriteLine("Молодец!!!!!!!!!!!");
                Start();
                CaseS = int.Parse(Console.ReadLine());
                SelectedCase(CaseS);
            }
            catch (Exception e) { Console.WriteLine(e.ToString()); }
        }

        public static void PrintTable()
        {
            try
            {
                var table = new int[10, 10];
                for (int i = 1; i < 10; ++i)
                {
                    for (int j = 1; j < 10; ++j)
                    {
                        table[j, i] = j * i;
                    }
                }
                for (int i = 1; i < 10; ++i)
                {
                    for (int j = 1; j < 10; ++j)
                    {
                        Console.Write("{0, 3}", table[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Start();
                CaseS = int.Parse(Console.ReadLine());
                SelectedCase(CaseS);
            }
            catch (Exception e) { Console.WriteLine(e.ToString()); }
        }

        public static void MathFunction()
        {
            try
            {
                Console.WriteLine("Введите число:");
                int chislo = int.Parse(Console.ReadLine());
                if (chislo <= 0) Console.WriteLine("Введите число больше 0!");
                for (int p = 1; p < chislo; p++)
                {
                    if (chislo % p == 0)
                    {
                        Console.WriteLine("{0}", p);

                    }
                }
                Console.WriteLine(chislo);
                Start();
                CaseS = int.Parse(Console.ReadLine());
                SelectedCase(CaseS);
            }
            catch (Exception e) { Console.WriteLine(e.ToString()); }
        }
    }
}