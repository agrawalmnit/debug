using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    internal class Expense
    {

        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Location { get; set; }

        public DateOnly Date { get; set; }

        public double Amount { get; set; }

    }
}
