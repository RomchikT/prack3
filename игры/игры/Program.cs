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
            CaseS = Convert.ToInt32(Console.ReadLine());

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
                    int r = new Random().Next(0, 100);
                    int c;
                    Console.WriteLine("Угадай число от 0 до 100");
                    Console.WriteLine("Введите число:");
                    do
                    {
                        c = Convert.ToInt32(Console.ReadLine());
                        if (c < r) Console.WriteLine("Число больше!!!!!");
                        if (c > r) Console.WriteLine("Число меньше!!!!!");
                    }
                    while (c != r);

                    Console.WriteLine("Молодец!!!!!!!!!!!");
                    Start();
                    CaseS = Convert.ToInt32(Console.ReadLine());
                    SelectedCase(CaseS);
                    break;
                case 2:
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
                    CaseS = Convert.ToInt32(Console.ReadLine());
                    SelectedCase(CaseS);
                    break;
                case 3:
                    Console.WriteLine("Введите число:");
                    int chislo = Convert.ToInt32(Console.ReadLine());
                    if (chislo <= 0) Console.WriteLine("Введите число больше 0!");
                    for(int p = 1; p < chislo; p++)
                    {
                        if (chislo % p == 0 )
                        {
                            Console.WriteLine("{0}", p);
                            
                        }
                    }
                    Console.WriteLine(chislo);
                    Start();
                    CaseS = Convert.ToInt32(Console.ReadLine());
                    SelectedCase(CaseS);
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}