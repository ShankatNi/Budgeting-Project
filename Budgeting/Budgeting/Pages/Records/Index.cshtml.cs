using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Budgeting.Models;

namespace Budgeting.Pages.Records
{
    public class IndexModel : PageModel
    {
        private readonly Budgeting.Models.BudgetContext _context;

        public IndexModel(Budgeting.Models.BudgetContext context)
        {
            _context = context;
        }

        public IList<Record> Record { get; set; }

        public async Task OnGetAsync()
        {
            Record = await _context.Record.ToListAsync();
        }
    }
}
