using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CalleStore.Models;
using CalleStore.Data;
using CalleStore.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace CalleStore.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _context;

    public HomeController(ILogger<HomeController> logger, AppDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index(int? categoryId)
    {
        // HomeVM homeVM = new() {
        //     Categorias = _context.Categories.ToList(),
        //     Produtos = _context.Products.Include(p => p.Category).ToList()
        // };

        HomeVM homeVM = new()
        {
            Categorias = _context.Categories.ToList(),
            Produtos = categoryId == null
            ? _context.Products.Include(p => p.Category).ToList()
            : _context.Products.Include(p => p.Category).Where(p => p.CategoryId == categoryId).ToList(),
            CategoriaSelecionada = categoryId == null ? null : _context.Categories.FirstOrDefault(c => c.Id == categoryId),
        };
        return View(homeVM);
    }

    public IActionResult Product(int id, int categoryId)
    {
        Product produto = _context.Products
            .Include(p => p.Category)
            .FirstOrDefault(produto => produto.Id == id);

        ProductVM produtoVM = new()
        {
            Categorias = _context.Categories.ToList(),
            Produtos = categoryId == null
            ? _context.Products.Include(p => p.Category).ToList()
            : _context.Products.Include(p => p.Category).Where(p => p.CategoryId == categoryId).ToList(),
            CategoriaSelecionada = categoryId == null ? null : _context.Categories.FirstOrDefault(c => c.Id == categoryId),
            Produto = produto,
        };
        return View(produtoVM);
    }

    public IActionResult Registro()
    {
        return View();
    }

    public IActionResult Login()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
