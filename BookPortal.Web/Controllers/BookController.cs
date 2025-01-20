using BookPortal.Web.Data;
using BookPortal.Web.Models;
using BookPortal.Web.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BookPortal.Web.Controllers
{
    public class BookController : Controller
    {
        public readonly ApplicationDbContext dbContext;
        public BookController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddBookViewModel viewModel)
        {
            var book = new Book
            {
                Title = viewModel.Title,
                Author = viewModel.Author,
                Price = viewModel.Price,
                PublishedDate = viewModel.PublishedDate,
                Category = viewModel.Category,
            };
            await dbContext.Books.AddAsync(book);
            await dbContext.SaveChangesAsync();

            return View();
        }

    }
}
