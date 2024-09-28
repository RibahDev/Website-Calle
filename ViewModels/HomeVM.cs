using CalleStore.Models;

namespace CalleStore.ViewModels;

public class HomeVM
{
    public List<Categoria> Categorias { get; set; }
    public List<Product> Produtos { get; set; }

    public Categoria CategoriaSelecionada { get; set; }
}
