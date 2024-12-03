using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dotnet_lections.Models;
using mvc.Models;

namespace dotnet_lections.Controllers;

public class UserController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public UserController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var user = new User();
        user.FirstName = "Maksym";
        user.LastName = "Prykhodko";

        ViewData["FirstName"] = user.FirstName;
        return View(user);
    }

    public IActionResult New(string? FirstName, string? LastName)
    {
        // if (FirstName != null && LastName != null)
        // {
        //     var user = new User();
        //     user.FirstName = FirstName;
        //     user.LastName = LastName;
        //     return View("Index", user);

        // }
        return View();
    }

    public IActionResult Save(User user)
    {
        return View("Index", user);
    }


}
