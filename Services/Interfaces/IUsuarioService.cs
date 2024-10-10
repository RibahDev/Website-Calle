using CalleStore.ViewModels.Account;

namespace CalleStore.Services;

public interface IUsuarioService
{
    Task<UsuarioVM> GetUsuarioLogado();
}
