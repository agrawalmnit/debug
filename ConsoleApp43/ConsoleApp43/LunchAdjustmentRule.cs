﻿

namespace ConsoleApp44
{
    public class LunchAdjustmentRule : IAdjustmentRule
    {
        public bool IsApplicable(Expense ex)
        {
            if(ex.ExpenseType.Name.Contains("Meals & Entertainment") && 
                ex.Description.ToLower().Contains("lunch"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Evaluate(Expense ex)
        {
            if(ex.Price > 6.00)
            {
                return 6.00;
            }
            else
            {
                return ex.Price;
            }
        }
    }
}