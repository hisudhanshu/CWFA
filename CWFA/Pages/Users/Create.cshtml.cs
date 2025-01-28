using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CWFA.Data;
using CWFA.Model;

namespace CWFA.Pages.Users
{
    public class CreateModel : PageModel
    {
        private readonly CWFA.Data.CWFAContext _context;

        public CreateModel(CWFA.Data.CWFAContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public user user { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.user.Add(user);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
