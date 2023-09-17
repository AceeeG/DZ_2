using System;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная 2 главы\nУпражнение 2.1.\nВведите ваше имя:");

            string name = Console.ReadLine();
            Console.WriteLine($"\nПривет {name}, хорошего дня тебе\n");

            Console.WriteLine("Упражнение 2.2.\nВведите 2 числа, а программа выдаст результат деления первого на второе.\nЕсли вводите целые значения, пишите через запятую.\n\nВведите 1 число: ");

            string num1 = Console.ReadLine();
            if (num1.Contains("."))
                num1 = num1.Replace(".", ",");


            double a = Convert.ToDouble(num1);

            Console.WriteLine("Введите второе число:");

            string num2 = Console.ReadLine();
            if (num2.Contains("."))
                num2 = num2.Replace(".", ",");

            double b = Convert.ToDouble(num2);
            if (b == 0)
            {
                Console.WriteLine("На ноль делить нельзя.\nВведите 2 число снова: \n");
                num2 = Console.ReadLine();
                if (num2.Contains(".")) //Решил немного усложнить программу
                    num2 = num2.Replace(".", ",");
                b = Convert.ToDouble(num2);
                while (b == 0)
                {
                    Console.WriteLine("На ноль делить нельзя.\nВведите 2 число снова: \n"); 

                    num2 = Console.ReadLine();
                    if (num2.Contains("."))
                        num2 = num2.Replace(".", ",");

                    b = Convert.ToDouble(num2);
                }
                Console.WriteLine($"Результатом деления данных чисел будет {a / b}");
            }
            else
            {
                Console.WriteLine($"Результатом деления данных чисел будет {a / b}");
            }

            Console.WriteLine("Домашнее задание 2.1.\nВведите строчный символ английского алфавита, а программа выведет следующий\n");
            char[] alf = new[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            string sym = Console.ReadLine();
            a = (char)sym[0];
            char z = 'z';
            if (a == z)
            {
                Console.WriteLine("Следующий символ: a\n");
            }
            for(int i = 0; i < alf.Length; i++)
            {
                if (a == (alf[i]) && (a != (alf[alf.Length - 1])))
                {
                    Console.WriteLine($"Следующий символ: {alf[i + 1]}\n");
                }

            }
            for (int j = 0; j < alf.Length; j++)
            {
                if (a != (alf[j]))
                {
                    Console.WriteLine("Вы ввели не строчную букву английского алфавита");
                    break;
                }
            }


            Console.WriteLine("Домашнее задание 2.2\nНайти корни квадратного уравнения\nВведите первый коэфицент:");
            double first = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второй коэфицент:");
            double second = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите третий коэфицент:");
            double thirth = Convert.ToDouble(Console.ReadLine());
            double d = (Math.Pow(second, 2) - (4 * first * thirth));
            if (d == 0)
            {
                Console.WriteLine($"Уравнение имеет лишь один корень: {(b * (-1)) / 2}");
            }
            else if(d > 0)
            {
                Console.WriteLine($"Уравнение имеет два корня: {(b * (-1) + Math.Sqrt(d)) / 2} и {(b * (-1) - Math.Sqrt(d)) / 2}");
            }
            else
            {
                Console.WriteLine("Нет вещественных корней");
            }
            
            Console.ReadKey();
        }
    }
}
