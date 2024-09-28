using CalleStore.Models;

namespace CalleStore.ViewModels
{
    public class ProductVM
    {
        public Product Produto { get; set; }

        public List<Categoria> Categorias { get; set; }
        public Categoria CategoriaSelecionada { get; set; }
        public object Produtos { get; internal set; }
    }
}