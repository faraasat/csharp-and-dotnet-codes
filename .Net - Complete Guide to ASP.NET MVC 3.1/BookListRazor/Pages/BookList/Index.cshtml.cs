using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookListRazor.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Book> Books { get; set;  }

        // By doing this Books Enumerable will be available to the cshtml file
        public async Task OnGet()
        {
            Books = await _db.Book.ToListAsync();
        }

        // We have handler name "Delete" From Index.cshtml after OnPost
        public async Task<IActionResult> OnPostDelete(int id)
        {
            var book = await _db.Book.FindAsync(id);
            if(book == null)
            {
                return NotFound();
            }

            _db.Book.Remove(book);
            _db.SaveChanges();

            return RedirectToPage("Index");
        }

    }
}