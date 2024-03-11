using Microsoft.AspNetCore.Mvc;
using Models.Commande;
using System;
using BLL;

namespace SiteWeb.Controllers
{
    public class CommandeController : Controller
    {
        private readonly CommandeService _commandeService;

        public CommandeController(CommandeService commandeService)
        {
            _commandeService = commandeService ?? throw new ArgumentNullException(nameof(commandeService));
        }

        public IActionResult Index(int id)
        {
            var vm = _commandeService.GetCommande(id);
            ViewData["TitrePage"] = "Ma commande";
            return View(vm);
        }

    }
}
