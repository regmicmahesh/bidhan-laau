using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using step2.Models;

namespace step2.Controllers;

public class Address{
    public string Name {get; set;}
}

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var username = TempData["a"] as string;
        // HttpContext.Session.GetString("a");

        return Content(username ?? "Guest");
    }

    public IActionResult Privacy(IFormCollection keyvalues)
    {
        var x = keyvalues["id"];
        // server side: sessions, tempdata
        // client side: cookies, query parameters, html hidden input

        // HttpContext.Session.SetInt32
        // HttpContext.Session.SetString("a", "b");
        TempData["a"] = "Ram";

        Response.Cookies.Append("ram", "shyam");

        // ViewBag.X = "3";


        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
