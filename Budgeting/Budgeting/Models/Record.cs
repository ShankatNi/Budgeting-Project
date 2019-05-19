using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Budgeting.Models
{
    public class Record
    {
        public int ID { get; set; }
        public int Expenses { get; set; }
        public DateTime ExpensesDate { get; set; }

        public int Income { get; set; }
        public DateTime IncomeDate { get; set; }

    }
}
