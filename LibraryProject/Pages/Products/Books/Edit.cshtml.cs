using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LibraryProject.Data;
using LibraryProject.Data.Models;

namespace LibraryProject.Pages.Products.Books
{
    public class EditModel : PageModel
    {
        private readonly LibraryProjectContext _context;
        private IRepositoryBook repo;
        private IWebHostEnvironment env;

        public EditModel(LibraryProjectContext context, IRepositoryBook repo, IWebHostEnvironment env)
        {
            this.repo = repo;
            this.env = env;
            _context = context;

        }

        [BindProperty]
        public Book Book { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Book == null)
            {
                return NotFound();
            }

            var book = await _context.Book.FirstOrDefaultAsync(m => m.id == id);
            if (book == null)
            {
                return NotFound();
            }
            Book = book;
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


            if (Book.Upload is not null)
            {

                Book.coverImage = Book.Upload.FileName;


                var file = Path.Combine(env.ContentRootPath, "wwwroot/images/books", Book.Upload.FileName);
                using (var fileStream = new FileStream(file, FileMode.Create))
                {
                    Book.Upload.CopyTo(fileStream);
                }
            }
            _context.Attach(Book).State = EntityState.Modified;

            try
            {

                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookExists(Book.id))
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

        private bool BookExists(int id)
        {
            return (_context.Book?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
