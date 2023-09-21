using System;
using System.Threading;
namespace Examples
{
    
    enum Alchohol
    {
        Drunkard,
        Drinker,
        Party_Drinker,
        Sober
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
            Console.WriteLine($"Задание 1\nbyte - максимальное значение: {byte.MaxValue} - минимальное значение: {byte.MinValue} \n" +
                              $"sbyte - максимальное значение: {sbyte.MaxValue} - минимальное значение: {sbyte.MinValue} \n" +
                              $"short - максимальное значение: {short.MaxValue} - минимальное значение: {short.MinValue} \n" +
                              $"ushort - максимальное значение: {ushort.MaxValue} - минимальное значение: {ushort.MinValue} \n" +
                              $"int - максимальное значение: {int.MaxValue} - минимальное значение: {int.MinValue} \n" +
                              $"uint - максимальное значение: {uint.MaxValue} - минимальное значение: {uint.MinValue} \n" +
                              $"long - максимальное значение: {long.MaxValue} - минимальное значение: {long.MinValue} \n" +
                              $"ulong - максимальное значение: {ulong.MaxValue} - минимальное значение: {ulong.MinValue} \n" +
                              $"float - максимальное значение: {float.MaxValue} - минимальное значение: {float.MinValue} \n" +
                              $"double - максимальное значение: {double.MaxValue} - минимальное значение: {double.MinValue} \n" +
                              $"decimal - максимальное значение: {decimal.MaxValue} - минимальное значение: {decimal.MinValue} \n");


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

            Console.WriteLine("Задание 3\nВведите вашу строку");
            string txt = Console.ReadLine();
            string answer = "";
            for(int i = 0; i < txt.Length; i++)
            {
                if (txt[i] != txt.ToUpper()[i])
                {
                    answer += txt.ToUpper()[i];
                }
                else
                {
                    answer += txt.ToLower()[i];
                }
            }
            Console.WriteLine($"Обработаная строка:\n{answer}");


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
            Console.WriteLine($"Чтобы окупить отдых нужно столько бутылок: {Math.Ceiling(profit)}");

            Console.WriteLine("Задание 6 - повтор диаолога\nДля начала поздоровайтесь\n");
            Random rand = new Random();
            System.ConsoleColor[] color = {ConsoleColor.Red, ConsoleColor.Blue, ConsoleColor.Green, ConsoleColor.Yellow, ConsoleColor.White, ConsoleColor.Gray, ConsoleColor.DarkRed, ConsoleColor.DarkBlue, ConsoleColor.DarkGreen, ConsoleColor.DarkYellow, ConsoleColor.DarkGray};

            System.ConsoleColor console_color = color[rand.Next(12)];

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
            Console.BackgroundColor = console_color;
            Console.Clear();
            Thread.Sleep(1000);
            Console.BackgroundColor = ConsoleColor.Black;
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
                Console.WriteLine($"При штрих - коде: {ean13}\nКонтрольная цифра равна {10 - last_num}\n");
            }
            
            Console.WriteLine("Задание 8 - создаю 5 студентов\n");

            Student student1 = new Student();
            student1.surname = "Иванов";
            student1.name = "Ваня";
            student1.id = 1;
            student1.alchohol = Alchohol.Drunkard;
            student1.liter = 2;
            student1.Counter();

            Student student2 = new Student();
            student2.surname = "Саблин";
            student2.name = "Жорик";
            student2.id = 2;
            student2.alchohol = Alchohol.Drinker;
            student2.liter = 1;
            student2.Counter();

            Student student3 = new Student();
            student3.surname = "Белый";
            student3.name = "Саша";
            student3.id = 3;
            student3.alchohol = Alchohol.Drinker;
            student3.liter = 1.5;
            student3.Counter();

            Student student4 = new Student();
            student4.surname = "Ревва";
            student4.name = "Алекс";
            student4.id = 4;
            student4.alchohol = Alchohol.Sober;
            student4.liter = 0;
            student4.Counter();

            Student student5 = new Student();
            student5.surname = "Спортик";
            student5.name = "Серега";
            student5.id = 5;
            student5.alchohol = Alchohol.Party_Drinker;
            student5.liter = 0.5;
            student5.Counter();

            double liters = student1.liter + student2.liter + student3.liter + student4.liter + student5.liter;
            Console.WriteLine($"В общем студенты выпили столько литров: {liters}.\n{student1.name} {student1.surname} выпил {(student1.liter / liters) * 100} процентов\n" +
                $"{student2.name} {student2.surname} выпил {(student2.liter / liters) * 100} процентов\n" +
                $"{student3.name} {student3.surname} выпил {(student3.liter / liters) * 100} процентов\n" +
                $"{student4.name} {student4.surname} выпил {(student4.liter / liters) * 100} процентов\n" +
                $"{student5.name} {student5.surname} выпил {(student5.liter / liters) * 100} процентов\n");

            Console.WriteLine("Для завершения нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
