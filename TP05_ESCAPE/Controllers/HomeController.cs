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
    public IActionResult VerificarCodigo()
    {
        var json = HttpContext.Session.GetString("juego");
        var usuario = Objeto.StringToObject<Juego>(json);
        return View();
    }
    public IActionResult Index()
    {
        return View();
    }
     [HttpPost]
    public IActionResult Login (string usuario, string contraseña) {
        ViewBag.usuario = usuario;
        ViewBag.contraseña = contraseña;
        var juego = new Juego();

        HttpContext.Session.SetString("juego", Objeto.ObjectToString(juego));
        return View ("Historia");
    }
     public IActionResult historia () {
     
        return View ("Etapa1");
    }
     public IActionResult volver () {
     
        return View ("Index");
    }
    public IActionResult creditos ()
    {
        return View ("Creditos");
    }
    
    [HttpPost]
     public IActionResult ResolverSala (string respuesta)
    {      
        var json = HttpContext.Session.GetString("juego");
        Juego juego = Objeto.StringToObject<Juego>(json);

        juego.ArriesgarCodigo(respuesta);
        HttpContext.Session.SetString("juego", Objeto.ObjectToString(juego));
        return View("Etapa"+ juego.nroSala);
    
    }

}


