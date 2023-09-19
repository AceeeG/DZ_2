using System;


namespace Lab2
{
    enum Bank
    {
        Salary,
        Savings
    }

    struct Client
    {
        public long id; //переменная типа long т.к номер банковского карты это 16 символов, а это уже не вмещается в int
        public string type;
        public int balance;
        public void Print()
        {
            Console.WriteLine($"Номер вашего счёта: {id},\nТип вашего счёта: {type},\nБаланс вашего счёта: {balance}\n");
        }

    }
    enum Vuz
    {
        KFU,
        KAI,
        KHTI
    }
    struct Worker
    {
        public string name;
        public Vuz vuz;
        public void Print()
        {
            Console.WriteLine($"{name} работает в {vuz}\n");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная 3 главы\nУпражнение 3.1 - работа с перечислениями(enum)\n");
            Bank bank_account = Bank.Savings;
            Console.WriteLine($"Тип вашего банковского счета {bank_account}\n");

            Console.WriteLine("Упражнение 3.2 - работа со структурами\n");
            
            Client client = new Client();
            client.id = 1111222233334444;
            client.type = "Savings";
            client.balance = 3200;
            client.Print();

            Console.WriteLine("Домашнее задание 3.1\nИспользуем enum как тип данных\n");
            Worker worker = new Worker();
            worker.name = "Олег";
            worker.vuz = 0;
            worker.Print();

            Console.ReadKey();
        }
    }
}
