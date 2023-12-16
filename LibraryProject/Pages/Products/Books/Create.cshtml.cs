using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LibraryProject.Data;
using LibraryProject.Data.Models;

namespace LibraryProject.Pages.Products.Books
{
    public class CreateModel : PageModel
    {
        private IRepositoryBook repo;
        private IWebHostEnvironment env;

        [BindProperty]
        public Book Book { get; set; }
        public void OnGet()
        {
        }

        public CreateModel(IRepositoryBook repo, IWebHostEnvironment env)
        {
            this.repo = repo;
            this.env = env;
        }
        public IActionResult OnPost()
        {

            if (!ModelState.IsValid) { return Page(); }

            if (Book.Upload is not null)
            {
                Book.coverImage = Book.Upload.FileName;

                var file = Path.Combine
                    (env.ContentRootPath
                        , "wwwroot/images/books"
                        , Book.Upload.FileName
                    );
                using (var filestream = new FileStream(file, FileMode.Create))
                {
                    Book.Upload.CopyTo(filestream);
                }

            }

            Book.Created = DateTime.Now;

            repo.Add(Book);

            return RedirectToPage("./Index");

        }
    }
}
