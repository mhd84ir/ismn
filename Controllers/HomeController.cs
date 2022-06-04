using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ismn.Models;

namespace ismn.Controllers;

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
    public IActionResult events()
    {
        return View();
    }
    public IActionResult rexelweb()
    {
        return View();
    }
    public IActionResult waveforms()
    {
        return View();
    }
    public IActionResult stations()
    {
        return View();
    }
}
