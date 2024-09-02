using CalleStore.Models;

namespace CalleStore.ViewModels
{
    public class ProductVM
    {
        public Product Produto { get; set; }

        public List<Category> Categorias { get; set; }
        public Category CategoriaSelecionada { get; set; }
        public object Produtos { get; internal set; }
    }
}