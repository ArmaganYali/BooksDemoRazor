using BooksDemoRazor.Data.Access;
using BooksDemoRazor.Data.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BooksDemoRazor.Pages
{
    [BindProperties]
    public class DeleteModel : PageModel
    {

        public Book? Book { get; set; }


        private AppDBContext _db;
        public DeleteModel(AppDBContext db)
        {
            _db = db;
        }
        public void OnGet(int id)
        {
            Book = _db.Books.Find(id);
            //Book = _db.Books.FirstOrDefault(b => b.Id == id);
            //Book = _db.Books.SingleOrDefault(b => b.Id == id);
            //Book = _db.Books.Where(b => b.Id == id).FirstOrDefault();
        }

        public IActionResult OnPost(Book book)
        {
            var bookForDelete= _db.Books.Find(Book.Id);
            // Veritabaný EF
            _db.Books.Remove(bookForDelete);
            _db.SaveChanges();
            TempData["kayitSilindi"] = "Kayýt Silindi!!!!!";
            return RedirectToPage("index");

        }
    }
}
