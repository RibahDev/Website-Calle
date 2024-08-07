using CalleStore.Models;

namespace CalleStore.ViewModels;

public class HomeVM
{
    public List<Category> Categorias { get; set; }
    public List<Product> Produtos { get; set; }

    public Category CategoriaSelecionada { get; set; }
}
