using BLL;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookService _bookService;

        public BookController(BookService bookService)
        {
            _bookService = bookService;

        }
        public IActionResult Index()
        {
            CategorieService categorieService = new CategorieService();

            ViewData["TitrePage"] = "Nos Livres  par Catégorie";
            ViewData["DescriptioPage"] = "Description de la page Catégorie";

            return View(categorieService.ListDetailVM());
        }


      

        public IActionResult Details(int id)
        {
            var book = _bookService.GetBookById(id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }
        
    
    }
}
