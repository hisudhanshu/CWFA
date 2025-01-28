using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CWFA.Data;
using CWFA.Model;

namespace CWFA.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly CWFA.Data.CWFAContext _context;

        public IndexModel(CWFA.Data.CWFAContext context)
        {
            _context = context;
        }

        public IList<user> user { get;set; } = default!;

        public async Task OnGetAsync()
        {
            user = await _context.user.ToListAsync();
        }
    }
}
