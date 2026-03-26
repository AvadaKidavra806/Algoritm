using System;

//
namespace Zadachi
{
    class Zapolnenie
    {
        public void Vuvod()
        {
            Console.WriteLine("Заполнение и вывод");
            Console.Write("Введите номер задания: ");
            byte NomerZadaniy = 1; bool NomerZadaniyOut = true;
            while (NomerZadaniyOut)
            {
                if (!byte.TryParse(Console.ReadLine(), out NomerZadaniy) || NomerZadaniy <= 0)
                    Console.Write("Ошибка! Введите номер задания еще раз ");
                /*else if (NomerZadaniy <= 0 || NomerZadaniy > 21)
                    Console.Write("В дз всего 21 заданий, Введите номер задания еще раз ");*/
                else
                    NomerZadaniyOut = false;

            }
            switch (NomerZadaniy)
            {
                case 1:
                    n1();
                    break;
                    case 2:
                    n2();
                    break;
                    case 3:
                    n3();
                        break;
                default:
                    Console.WriteLine("Пока что не готов этот номер ");
                    break;
            }
            void n1 ()
            {
                const int kolvostrok = 9;
                const int kolvostolb = 9;
                int[,] massiv = new int[kolvostrok, kolvostolb];
                for(int i = 0; i <kolvostrok; i++)
                {
                    for(int j = 0; j <kolvostolb; j++)
                    {
                        massiv[i, j] = (i + 1) * (j + 1);
                        Console.Write(massiv[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            void n2 ()
            {
                Console.WriteLine("Задание а ");
                const int kolvostrok = 7;
                const int kolvostolb = 7;
                int[,] massiv = new int[kolvostrok, kolvostolb];
                for (int i = 0; i  < kolvostrok; i++)
                {
                    for (int j = 0; j < kolvostolb; j++)
                    {
                        if (i == j || (i + j == kolvostrok - 1))
                        {
                            massiv[i, j] = 1;
                        }
                        else
                        {
                            massiv[i, j] = 0;
                        }
                        Console.Write(massiv[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Задание б ");
                for (int i = 0; i <kolvostrok; i++)
                {
                    for (int j = 0; j < kolvostolb; j++)
                    {
                        if (i == j || i + j == kolvostrok - 1 || j == 3 || i == 3)
                        {
                            massiv[i, j] = 1;
                        }
                        else
                        {
                            massiv[i, j] = 0;
                        }
                        Console.Write(massiv[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Задание в ");
                for (int i = 0; i <kolvostrok; i++)
                {
                    for (int j = 0; j < kolvostolb; j++)
                    {
                        if ((i <= j || kolvostrok - 1 - i <= j) && (j <= kolvostolb - 1 - i || i >= j))
                        {
                            massiv[i, j] = 1;
                        }
                        else
                        {
                            massiv[i, j] = 0;
                        }
                        Console.Write(massiv[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            void n3 ()
            {
                Console.WriteLine("Задание а ");
                const int kolvostrok = 6;
                const int kolvostolb = 6;
                int[,] massiv = new int[kolvostrok, kolvostolb];
                for (int i = 0; i < kolvostrok; i++)
                {
                    for (int j = 0; j < kolvostolb; j++)
                    {
                        if (i == 0 || j == 0)
                        {
                            massiv[i, j] = 1;
                        }
                        else
                        massiv[i, j] = massiv[i - 1, j] + massiv[i, j - 1];
                        Console.Write(massiv[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Задание б ");
                for (int i = 0; i < kolvostrok; i++)
                {
                    for (int j = 0; j < kolvostolb; j++)
                    {
                        if (i == 0)
                            massiv[i, j] = 1 + j;
                        else if (massiv[i - 1, j] == 6)
                            massiv[i, j] = 1;
                        else
                            massiv[i, j] = massiv[i - 1, j] + 1;
                        Console.Write(massiv[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
            Console.Write("Для завершения программы нажмите Enter");
            Console.ReadLine();
        }
    }
}