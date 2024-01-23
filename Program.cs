using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main (string[] args)
        {
            try
            {
                //12 вариант
                Console.WriteLine("ЗАДАНИЕ 12\n");
                Console.Write("Введите количество групп на каждом курсе: ");
                int gr = int.Parse(Console.ReadLine());
                if (gr > 0 && gr < 11)
                {
                    int k = 5;
                    int[,] inst = new int[k, gr];
                    Random rnd = new Random();
                    for (int i = 0; i < inst.GetLength(0); i++)
                    {
                        for (int j = 0; j < inst.GetLength(1); j++)
                        {

                            if (i == 0)
                                inst[i, j] = rnd.Next(22, 26);
                            else
                                inst[i, j] = rnd.Next(10, 26);
                            Console.Write($"{inst[i, j],3}");
                        }
                        Console.WriteLine();
                    }
                    Console.Write("Введите номер курса, на котором вы бы хотели узнать количество студентов: ");
                    int kurs = int.Parse(Console.ReadLine());
                    if (kurs > 0 && kurs < 6)
                    {
                        int kolvo_stud = 0;
                        for (int j = 0; j < gr; j++)
                        {
                            kolvo_stud += inst[kurs - 1, j];
                        }
                        Console.WriteLine($"Колиечтво студентов на {kurs} курсе: {kolvo_stud}");
                    }
                    else
                        Console.WriteLine("Вы произвели неправильный ввод");
                }
                else
                    Console.WriteLine("Вы произвели неправильный ввод");


                //7 вариант
                Console.WriteLine("\nЗАДАНИЕ 7\n");
                Console.Write("Количество строк (не менее 5): ");
                int m = int.Parse(Console.ReadLine());
                if (m >= 5)
                {
                    Console.Write("Колиество столбцов (не менее 4): ");
                    int n = int.Parse(Console.ReadLine());
                    if (n >= 4)
                    {
                        int[,] dvum = new int[m, n];
                        //заполнение массива
                        for (int i = 0; i < dvum.GetLength(0); i++)
                        {
                            for (int j = 0; j < dvum.GetLength(1); j++)
                            {
                                Console.Write($"Введите число в {j + 1} столбец {i + 1} строку: ");
                                dvum[i, j] = Convert.ToInt32(Console.ReadLine());
                            }
                            Console.WriteLine("---------------------");
                        }
                        //вывод массива
                        for (int i = 0; i < dvum.GetLength(0); i++)
                        {
                            for (int j = 0; j < dvum.GetLength(1); j++)
                            {
                                Console.Write($"{dvum[i, j],3}");
                            }
                            Console.WriteLine();
                        }
                        //1 подпункт
                        int second_stolb = 0;
                        for (int i = 0; i < dvum.GetLength(0); i++)
                        {
                            if (dvum[i,1]>15)
                            second_stolb ++;
                        }
                        Console.WriteLine($"Количество ненулевых чисел больше 15 во втором столбце: {second_stolb}");
                        //2 подпункт
                        int sum5 = 0, kolvo5 = 0;
                        double sred5 = 0;
                        for (int j = 0; j < dvum.GetLength(1); j++)
                        {
                            if (dvum[4, j] % 2 != 0)
                            {
                                sum5 += dvum[4, j];
                                kolvo5++;
                            }
                        }
                        double str5 = sum5 / kolvo5;
                        sred5= Math.Round(str5, 2);
                        Console.WriteLine($"Среднее арифметическое нечётных чисел 5 строки : {sred5}");
                        //3 подпункт
                        int sum4 = 0, kolvo4 = 0;
                        double sred4 = 0;
                        for (int i = 0; i < dvum.GetLength(0); i++)
                        {
                            if (dvum[i, 3] % 4 == 0)
                            {
                                sum4 += dvum[i, 3];
                                kolvo4++;
                            }
                        }
                        double stolb4 = sum4 / kolvo4;
                        sred4 = Math.Round(stolb4, 2);
                        Console.WriteLine($"Среднее арифметическое чисел 4 столбца кратных четырём: {sred4}");
                    }
                    else
                        Console.WriteLine("Вы произвели неправильный ввод");
                }
                else
                    Console.WriteLine("Вы произвели неправильный ввод");
              
            }
            catch { Console.WriteLine("Вы произвели неправильный ввод"); }

            Console.ReadKey();
        }
    }
}
