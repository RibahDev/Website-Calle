using CalleStore.Data;
using CalleStore.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Adicionar DbContext com banco de dados InMemory
builder.Services.AddDbContext<AppDbContext>(options => 
    options.UseInMemoryDatabase("CalleStoreDb")
);

// Configuração do Identity
builder.Services.AddIdentity<IdentityUser, IdentityRole>(opt => 
    opt.SignIn.RequireConfirmedAccount = false
)
.AddEntityFrameworkStores<AppDbContext>()
.AddDefaultTokenProviders();

// Registro dos serviços
builder.Services.AddScoped<IHomeService, HomeService>();
builder.Services.AddScoped<IProdutoService, ProdutoService>(); // Registro do IProdutoService

// Adicionar Controllers com Views
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Garantir que o banco de dados está criado
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    context.Database.EnsureCreated();
}

// Configuração do pipeline de requisições HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
