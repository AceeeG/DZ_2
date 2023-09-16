using System;


namespace Lab2
{
    enum Bank
    {
        Salary,
        Savings
    }
    internal class Program
    {
        static void Main(string[] args)
        { 
            
            Bank bank_account = Bank.Savings;
            Console.WriteLine($"Тип вашего банковского счета {bank_account}");



            Console.ReadKey();
        }
    }
}
