using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LibraryProject.Data;
using LibraryProject.Data.Models;

namespace LibraryProject.Pages.Products.CDs
{
    public class DeleteModel : PageModel
    {
        private readonly LibraryProjectContext _context;

        public DeleteModel(LibraryProjectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CD CD { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.CD == null)
            {
                return NotFound();
            }

            var cd = await _context.CD.FirstOrDefaultAsync(m => m.id == id);

            if (cd == null)
            {
                return NotFound();
            }
            else
            {
                CD = cd;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.CD == null)
            {
                return NotFound();
            }
            var cd = await _context.CD.FindAsync(id);

            if (cd != null)
            {
                CD = cd;
                _context.CD.Remove(CD);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
