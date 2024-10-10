using CalleStore.ViewModels;

namespace CalleStore.Services;

public interface IProdutoService
{
    Task<List<ProdutoVM>> GetProdutos();
}
