using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyMVC.Models;

namespace DojoSurveyMVC.Controllers;


public class HomeController : Controller
{
    public static List<Persona> ListaPersonas = new List<Persona>();
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [Route("")] 
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    [HttpGet]
    [Route("personas")]
    public IActionResult Personas(){
        return View("personas", ListaPersonas);
    }

    [HttpPost]
    [Route("procesa/login")]
    public IActionResult ProcesaLogin(Persona NuevaPersona){
        if(ModelState.IsValid){
            ListaPersonas.Add(NuevaPersona);
            Console.WriteLine(ListaPersonas);
            return RedirectToAction("personas");    
        }
        return View("Index");
    }

    [HttpGet]
    [Route("regresar/login")]
    public IActionResult RegresaLogin(){
        return View("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
