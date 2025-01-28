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
    public class DeleteModel : PageModel
    {
        private readonly CWFA.Data.CWFAContext _context;

        public DeleteModel(CWFA.Data.CWFAContext context)
        {
            _context = context;
        }

        [BindProperty]
        public user user { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.user.FirstOrDefaultAsync(m => m.id == id);

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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.user.FindAsync(id);
            if (user != null)
            {
                user = user;
                _context.user.Remove(user);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
