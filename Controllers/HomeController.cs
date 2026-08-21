using EventosApagones.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EventosApagones.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var apagones = _context.Apagones.ToList();
            return View(apagones);
        }
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Area,Tipo,Fecha,CantidadTM,Horas,Scrap,GastoReparacion,GastoTE,GastoOtroDesc,GastoOtro,Reporto")] Apagones apagón)
        {
            if (ModelState.IsValid)
            {
                // Guarda el registro en la base de datos
                _context.Add(apagón);
                _context.SaveChanges();

                // Redirecciona a la lista principal tras un registro exitoso
                return RedirectToAction(nameof(Index));
            }

            // Si los datos no son válidos, vuelve a mostrar el formulario con los errores
            return View(apagón);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
