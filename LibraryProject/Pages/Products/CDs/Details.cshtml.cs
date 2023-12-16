using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LibraryProject.Data;
using LibraryProject.Data.Models;

namespace LibraryProject.Pages.Products.CDs
{
    public class DetailsModel : PageModel
    {
        private readonly LibraryProjectContext _context;

        public DetailsModel(LibraryProjectContext context)
        {
            _context = context;
        }

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
    }
}
