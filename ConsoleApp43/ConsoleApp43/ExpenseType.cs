using System.ComponentModel.DataAnnotations;

namespace ConsoleApp44
{
    public class ExpenseType
    {
        public int ID { get; set; }

        [Display(Name = "Expense Type")]
        public string Name { get; set; }
        
        public int CategoryId { get; set; }
        public ExpenseTypeCategory Category { get; set; }

    }
}
