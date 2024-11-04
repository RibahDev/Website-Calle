using System.Security.Claims;
using CalleStore.Data;
using CalleStore.ViewModels.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CalleStore.Services;

public class UsuarioService : IUsuarioService
{
    private readonly AppDbContext _contexto;
    private readonly SignInManager<IdentityUser> _signInManager;
    private readonly UserManager<IdentityUser> _userManager;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public UsuarioService(AppDbContext contexto, SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager, IHttpContextAccessor httpContextAccessor)
    {
        _contexto = contexto;
        _signInManager = signInManager;
        _userManager = userManager;
        _httpContextAccessor = httpContextAccessor;
    }

    public async Task<UsuarioVM> GetUsuarioLogado()
    {
        var userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
        var userAccount = await _userManager.FindByIdAsync(userId);
        var user = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);
        if (user == null)
        {
            throw new Exception("Usuário não encontrado.");
        }   
        var usuario = await _contexto.Usuarios.Where(u => u.UsuarioId == userId).SingleOrDefaultAsync();
        var perfis = string.Join(", ", await _userManager.GetRolesAsync(userAccount));
        UsuarioVM usuarioVM = new() {
            UsuarioId = userId,
            Nome = usuario.Nome,
            DataNascimento = usuario.DataNascimento,
            Foto = usuario.Foto,
            Email = userAccount.Email,
            UserName = userAccount.UserName,
            Perfil = perfis
        };
        return usuarioVM;
    }
}
