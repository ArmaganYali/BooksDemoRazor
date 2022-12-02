using BooksDemoRazor.Data.Access;
using BooksDemoRazor.Data.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BooksDemoRazor.Pages
{

    public class CreateModel : PageModel
    {
        [BindProperty]
        public Book? Book { get; set; }


        private AppDBContext _db;
        public CreateModel(AppDBContext db)
        {
            _db = db;
        }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {       
                // Veritabaný insert
                _db.Books.Add(Book);
                _db.SaveChanges();
                TempData["basariliKayitGiris"] = "Kitap kayýt giriþi yapýldý";
                return RedirectToPage("index");


            }

            return Page();
        }
    }
}
