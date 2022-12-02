using BooksDemoRazor.Data.Access;
using BooksDemoRazor.Data.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BooksDemoRazor.Pages
{
    [BindProperties]
    public class EditModel : PageModel
    {

        public Book? Book { get; set; }


        private AppDBContext _db;
        public EditModel(AppDBContext db)
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
            // 
            _db.Books.Update(Book);
            _db.SaveChanges();
            return RedirectToPage("index");

        }
    }
}
