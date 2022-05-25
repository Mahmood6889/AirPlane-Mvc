using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AirPlane_Mvc.Models;

namespace AirPlane_Mvc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult Company()
    {
        return View();
    }

    public IActionResult Admin()
    {
        return View();
    }
    public IActionResult Fly()
    {
        return View();
    }
    public IActionResult addcompany()
    {
        return View();
    }
    public IActionResult addfly()
    {
        return View();
    }
    public IActionResult login()
    {
        return View();
    }
}
