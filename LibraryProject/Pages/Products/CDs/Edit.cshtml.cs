using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LibraryProject.Data;
using LibraryProject.Data.Models;

namespace LibraryProject.Pages.Products.CDs
{
    public class EditModel : PageModel
    {
        private readonly LibraryProjectContext _context;
        private IRepositoryCD repo;
        private IWebHostEnvironment env;

        public EditModel(LibraryProjectContext context, IRepositoryCD repo, IWebHostEnvironment env)
        {
            this.repo = repo;
            this.env = env;
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
            CD = cd;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }


            if (CD.Upload is not null)
            {

                CD.coverImage = CD.Upload.FileName;


                var file = Path.Combine(env.ContentRootPath, "wwwroot/images/cds", CD.Upload.FileName);
                using (var fileStream = new FileStream(file, FileMode.Create))
                {
                    CD.Upload.CopyTo(fileStream);
                }
            }
            _context.Attach(CD).State = EntityState.Modified;

            try
            {

                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CDExists(CD.id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CDExists(int id)
        {
            return (_context.CD?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
