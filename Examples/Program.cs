using System;
using System.CodeDom;
using System.Threading;

namespace Examples
{
    enum Alchohol
    {
        Алкаш,
        Пьющий,
        По_праздникам,
        Трезвый
    }
    enum Color
    {
        White,
        Red,
        Green,
        Blue,
        Yellow,
    }  
    struct Person
    {
        public string name;
        public string city;
        public int age;
        public string password;
        public void Print()
        {
            Console.WriteLine($"Пользователь по имени {name}, живёт в {city}, ему {age} лет, его пин-код {password}");
        }

    }

    struct Student
    {
        public string surname;
        public string name;
        public int id;
        public Alchohol alchohol;
        public double liter;
        public void Counter()
        {
            Console.WriteLine($"{name} выпил столько литров: {liter}");
        }

    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задания с 1 - 8\nЗадание 1 - работа с выводом\n\nbyte - Максимальное значение: 255, Минимальное: 0\n" +
                "sbyte - Максимальное значение: 127, Минимальное: -128\nshort - Максимальное значение: 32767, Минимальное: -32768\n" +
                "ushort - Максимальное значение: 65535, Минимальное: 0\nint - Максимальное значение: 2147483647, Минимальное: -2147483648\n" +
                "uint - Максимальное значение: 4294967295, Минимальное: 0\nlong - Максимальное значение: 9223372036854775807, Минимальное: -922337203685477808\n" +
                "ulong - Максимальное значение: 18446774073709551615, Минимальное: 0\nfloat - Максимальное значение: 3,402823e38, Минимальное: -3,402823e38\n" +
                "double - Максимальное значение: 1,797693e308, Минимальное: -1,797693e308\ndecimal - Максимальное значение: 7,992816e28, Минимальное: -7,992816e28\n" +
                "\nЗадание 2 - работа со struct\n");
            
            Person person = new Person();
            Console.WriteLine("Введите ваше имя: ");
            person.name = Console.ReadLine();
            Console.WriteLine("Введите ваш город: ");
            person.city = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст: ");
            person.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Придумайте пин-код: ");
            person.password =  Console.ReadLine();
            person.Print();

            Console.WriteLine("Задание 3\nПока не знаю как");
            string s = Console.ReadLine();


            Console.WriteLine("Задание 4 - находим количество вхождений подстроки в строку\nВведите строку");
            string text = Console.ReadLine();
            Console.WriteLine("Введите подстроку");
            string pod_text = Console.ReadLine();
            int count = (text.Length - text.Replace(pod_text, "").Length) / pod_text.Length; ;//Вычитаем из text все кроме вхождений pod_text и делим на длину pod_text
            Console.WriteLine($"Подтекст столько раз входит в текст: {count}\nЗадача 5\nВведите обычную стоимость бутылки:\n");
            int norm_price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сколько стоит бутылка в Duty Free:\n");
            int sale_price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите стоимость отдыха:\n");
            int holiday_price = Convert.ToInt32(Console.ReadLine());
            double profit = holiday_price / (norm_price - sale_price);
            Console.WriteLine($"Чтобы окупить отдых нужно столько бутылок: {Math.Ceiling(profit) * -1}");

            Console.WriteLine("Задание 6 - повтор диаолога\nДля начала поздоровайтесь\n");
            Console.ReadLine();
            Console.WriteLine("Как тебя зовут?");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет {name}");
            Console.ReadLine();
            Console.WriteLine("Да");
            Console.ReadLine();
            Console.WriteLine("Нет");
            Thread.Sleep(5000);
            Console.WriteLine("Но могу показать.");
            Thread.Sleep(1000);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            
            Console.WriteLine("Задание 7 - вычислить контрольную цифру штрихкода (EAN13).\nШтрих - код создаётся рандомно");
            Random rnd = new Random();
            int num1 = rnd.Next(10), num2 = rnd.Next(10), num3 = rnd.Next(10), num4 = rnd.Next(10), num5 = rnd.Next(10), num6 = rnd.Next(10), num7 = rnd.Next(10), num8 = rnd.Next(10), num9 = rnd.Next(10), num10 = rnd.Next(10), num11 = rnd.Next(10), num12 = rnd.Next(10), num13 = rnd.Next(10);
            string ean13 = Convert.ToString(num1) + Convert.ToString(num2) + Convert.ToString(num3) + Convert.ToString(num4) + Convert.ToString(num5) + Convert.ToString(num6) + Convert.ToString(num7) + Convert.ToString(num8) + Convert.ToString(num9) + Convert.ToString(num10) + Convert.ToString(num11) + Convert.ToString(num12) + Convert.ToString(num13);
            int sum = (num2 + num4 + num6 + num8 + num10 + num12) + ((num1 + num3 + num5 + num7 + num9 + num11 + num13) * 3);
            string sum1 = Convert.ToString(sum);
            int last_num = Convert.ToInt32(sum1.Substring(sum1.Length - 1));
            if (last_num == 0)
            {
                Console.WriteLine($"При штрих - коде: {ean13}\nКонтрольная цифра равна {last_num}");
            }
            else
            {
                Console.WriteLine($"При штрих - коде: {ean13}\nКонтрольная цифра равна {10 - last_num}");
            }
            
            Console.WriteLine("Задание 8 - создаю 5 студентов\n");

            Student student1 = new Student();
            student1.surname = "Иванов";
            student1.name = "Ваня";
            student1.id = 1;
            student1.alchohol = Alchohol.Алкаш;
            student1.liter = 2;
            student1.Counter();

            Student student2 = new Student();
            student2.surname = "Саблин";
            student2.name = "Жорик";
            student2.id = 2;
            student2.alchohol = Alchohol.Пьющий;
            student2.liter = 1;
            student2.Counter();

            Student student3 = new Student();
            student3.surname = "Белый";
            student3.name = "Саша";
            student3.id = 3;
            student3.alchohol = Alchohol.Пьющий;
            student3.liter = 1.5;
            student3.Counter();

            Student student4 = new Student();
            student4.surname = "Ревва";
            student4.name = "Алекс";
            student4.id = 4;
            student4.alchohol = Alchohol.Трезвый;
            student4.liter = 0;
            student4.Counter();

            Student student5 = new Student();
            student5.surname = "Спортик";
            student5.name = "Серега";
            student5.id = 5;
            student5.alchohol = Alchohol.По_праздникам;
            student5.liter = 0.5;
            student5.Counter();

            double liters = student1.liter + student2.liter + student3.liter + student4.liter + student5.liter;
            Console.WriteLine($"В общем студенты выпили столько литров: {liters}.\n{student1.name} {student1.surname} выпил {(student1.liter / liters) * 100} процентов\n" +
                $"{student2.name} {student2.surname} выпил {(student2.liter / liters) * 100} процентов\n" +
                $"{student3.name} {student3.surname} выпил {(student3.liter / liters) * 100} процентов\n" +
                $"{student4.name} {student4.surname} выпил {(student4.liter / liters) * 100} процентов\n" +
                $"{student5.name} {student5.surname} выпил {(student5.liter / liters) * 100} процентов\n");
            
            Console.ReadKey();
        }
    }
}
