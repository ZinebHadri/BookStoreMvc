using Microsoft.AspNetCore.Mvc;
using Models;
using BLL;
using Models.Register;

public class UserController : Controller
{
    public IActionResult Register()
    {
        
        return View();
    }

    [HttpPost]
    public IActionResult Register(UserViewModel model)
    {
        return RedirectToAction("Index", "Home");
    }

    public IActionResult Login()
    {
     
        return View();
    }

    [HttpPost]
    public IActionResult Login(LoginViewModel model)
    {
      
        return RedirectToAction("Index", "Home");
    }

    public IActionResult Logout()
    {
        
        return RedirectToAction("Index", "Home");
    }
}
