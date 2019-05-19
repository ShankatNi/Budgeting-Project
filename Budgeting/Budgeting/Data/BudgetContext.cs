using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Budgeting.Models
{
    public class BudgetContext : DbContext
    {
        public BudgetContext (DbContextOptions<BudgetContext> options)
            : base(options)
        {
        }

        public DbSet<Budgeting.Models.Record> Record { get; set; }
    }
}
