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
    public class DetailsModel : PageModel
    {
        private readonly CWFA.Data.CWFAContext _context;

        public DetailsModel(CWFA.Data.CWFAContext context)
        {
            _context = context;
        }

        public user user { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            user = await _context.user.FirstOrDefaultAsync(m => m.id == id);
            //var user = await _context.user.FirstOrDefaultAsync(m => m.id == id);
            if (user == null)
            {
                return NotFound();
            }
            else
            {
                user = user;
            }
            return Page();
        }
    }
}
