using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LibraryProject.Data;
using LibraryProject.Data.Models;

namespace LibraryProject.Pages.Products.CDs
{
    public class IndexModel : PageModel
    {
        private readonly LibraryProjectContext _context;

        public IndexModel(LibraryProjectContext context)
        {
            _context = context;
        }

        public IList<CD> CD { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.CD != null)
            {
                CD = await _context.CD.ToListAsync();
            }
        }
    }
}
