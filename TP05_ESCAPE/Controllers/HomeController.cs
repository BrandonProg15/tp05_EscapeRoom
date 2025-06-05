using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP05_ESCAPE.Models;

namespace TP05_ESCAPE.Controllers;

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
}
