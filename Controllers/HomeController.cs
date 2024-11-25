using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CalleStore.Models;
using CalleStore.Services;
namespace CalleStore.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IHomeService _homeService;

    public HomeController(ILogger<HomeController> logger, IHomeService homeService)
    {
        _logger = logger;
        _homeService = homeService;
    }

    public async Task<IActionResult> Index()
    {
        return View(await _homeService.GetIndexData());
    }

    public IActionResult Loja()
    {
        return View();
    }

    public async Task<IActionResult> Produtos()
    {
        return View(await _homeService.GetIndexData());
    }

    public IActionResult Blog()
    {
        return View();
    }

    public IActionResult Contatos()
    {
        return View();
    }

    public IActionResult Termos()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
