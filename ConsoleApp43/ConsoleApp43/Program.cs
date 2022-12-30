

using System;

namespace ConsoleApp43
{
    public class Program
    {
        public static void Main(string[] args)
        {


            ExpenseManager expenseManager = new ExpenseManager();

            const string exitOption = "6";

            string? input;
            do
            {
                Console.WriteLine("Expense app menu");
                Console.WriteLine("1- view expenses");
                Console.WriteLine("2- enter new expense");
                Console.WriteLine("3- edit expense");
                Console.WriteLine("4- delete expense");
                Console.WriteLine("5- total expenses");
                Console.WriteLine($"{exitOption} , exit application");

                Console.WriteLine();
                Console.Write("please select an option");
                input = Console.ReadLine();

                Console.WriteLine();

                if (input != null && input != "")
                {
                    int menuOption = int.Parse(input);

                    switch (menuOption)
                    {
                        case 1:
                            expenseManager.GetExpenses();
                            break;
                        case 2:
                            expenseManager.CreateExpense();
                            break;
                        case 3:
                            expenseManager.EditExpense();
                            break;
                        case 4:
                            expenseManager.DeleteExpense();
                            break;
                        case 5:
                            expenseManager.TotalExpenses();
                            break;
                        case 6:
                            Console.WriteLine("exit app chosen");
                            break;
                    }
                }

                Console.WriteLine();
            }

            while (input != exitOption);
            Console.WriteLine("exiting app");

        }
    }
}