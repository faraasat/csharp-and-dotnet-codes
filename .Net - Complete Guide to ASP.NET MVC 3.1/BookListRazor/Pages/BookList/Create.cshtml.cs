using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookListRazor.Pages.BookList
{
    public class CreateModel : PageModel
    {

        private readonly ApplicationDbContext _db;

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]  // On binding property app will assume that on the post we are getting that property
        public Book Book { get; set; }

        public void OnGet()
        {

        }

        // handler name will always be started with On
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)  // It checks the validity such as required property or data type and this validation is done on server side
            {
                await _db.Book.AddAsync(Book);  // This not added to db only added to que
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}