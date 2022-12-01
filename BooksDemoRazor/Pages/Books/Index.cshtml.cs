using BooksDemoRazor.Data.Access;
using BooksDemoRazor.Data.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BooksDemoRazor.Pages.Books
{
    public class IndexModel : PageModel
    {
        public IEnumerable<Book> Books { get; set; } 
        public AppDBContext _context { get; set; }  

        public IndexModel(AppDBContext db) 
        {
            _context = db;
           
        
        }

        public void OnGet()
        {
            Books=_context.Books;

        }
    }
}
