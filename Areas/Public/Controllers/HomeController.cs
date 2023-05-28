using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TiendaWeb.Models;
using TiendaWeb.Data;
using Microsoft.EntityFrameworkCore;

namespace TiendaWeb.Controllers;

[Area("Public")]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ApplicationDbContext _context;

    public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var productos = _context.Productos.Include(p => p.categoria);
        return View(await productos.ToListAsync());
    }

    public async Task<IActionResult> Details(int? id)
    {
        var producto = _context.Productos.Include(p => p.categoria).FirstOrDefaultAsync(p => p.id==id);
        return View(await producto);
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
}
