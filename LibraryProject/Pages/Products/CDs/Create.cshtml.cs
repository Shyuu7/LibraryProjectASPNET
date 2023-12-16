using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LibraryProject.Data;
using LibraryProject.Data.Models;

namespace LibraryProject.Pages.Products.CDs
{
    public class CreateModel : PageModel
    {
        private IRepositoryCD repo;
        private IWebHostEnvironment env;

        [BindProperty]
        public CD CD { get; set; }
        public void OnGet()
        {
        }

        public CreateModel(IRepositoryCD repo, IWebHostEnvironment env)
        {
            this.repo = repo;
            this.env = env;
        }
        public IActionResult OnPost()
        {

            if (!ModelState.IsValid) { return Page(); }

            if (CD.Upload is not null)
            {
                CD.coverImage = CD.Upload.FileName;

                var file = Path.Combine
                    (env.ContentRootPath
                        , "wwwroot/images/cds"
                        , CD.Upload.FileName
                    );
                using (var filestream = new FileStream(file, FileMode.Create))
                {
                    CD.Upload.CopyTo(filestream);
                }

            }

            CD.Created = DateTime.Now;

            repo.Add(CD);

            return RedirectToPage("./Index");

        }
    }
}
