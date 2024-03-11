using BLL;
using Microsoft.AspNetCore.Mvc;
using Models;
using System;

namespace SiteWeb.Controllers
{
    public class CategorieController : Controller
    {
        private readonly CategorieService _categorieService;

        public CategorieController(CategorieService categorieService)
        {
            _categorieService = categorieService ?? throw new ArgumentNullException(nameof(categorieService));
        }

        public IActionResult Index()
        {

            var categories = _categorieService.ListDetailVM();
            return View(categories);
        }

        public IActionResult Detail(int id)
        {
            var categorie = _categorieService.GetCategoryById(id);
            if (categorie == null)
            {
                return NotFound();
            }
            return View(categorie);
        }

      
    }
}
