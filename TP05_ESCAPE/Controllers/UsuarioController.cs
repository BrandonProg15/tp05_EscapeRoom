using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP05_ESCAPE.Models;

namespace TPAhorcado.Controllers;
public class UsuarioController : Controller
{
    [HttpGet]
    public IActionResult Registrar()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Registrar(string nombre, string contraseña, string dni)
    {
        var usuario = new Usuario(nombre, contraseña, dni);

        HttpContext.Session.SetString("usuario", Objeto.ObjectToString(usuario));

        HttpContext.Session.SetString("nombreUsuario", nombre);

        return RedirectToAction("Bienvenida");
    }

    public IActionResult Bienvenida()
    {
        var json = HttpContext.Session.GetString("usuario");
        var usuario = Objeto.StringToObject<Usuario>(json);

        var nombre = HttpContext.Session.GetString("nombreUsuario");

        ViewBag.Nombre = usuario.Nombre;
        ViewBag.Contraseña = usuario.Contraseña;
        ViewBag.Dni = usuario.ObtenerDni();
        ViewBag.usuarioActual = usuario;
        ViewBag.NombreDesdeString = nombre;

        return View();
    }
}