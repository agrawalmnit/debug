using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    internal class DataInitializer
    {

        public List<Expense> CreateSampleExpenses()
        {

            List<Expense> expenses = new List<Expense>();
            {

                new Expense
                {
                    ID = 1,
                    Name = "Lunch",
                    Date = new DateOnly(2022, 03, 02),
                    Location = "the sandwhich shack",
                    Amount = 7.50
                };

                new Expense
                {
                    ID = 2,
                    Name = "Stapels",
                    Date = new DateOnly(2022, 03, 02),
                    Location = "the office shop",
                    Amount = 2.50

                };

                new Expense
                {

                    ID = 3,
                    Name = "Gas",
                    Date = new DateOnly(2022, 03, 02),
                    Location = "the gas depot",
                    Amount = 12.5
                };



            };
            return expenses;

        } }
}
