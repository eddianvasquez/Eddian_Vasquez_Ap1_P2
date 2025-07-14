using Blazored.Toast;
using Eddian_Vasquez_Ap1_P2.Components;
using Eddian_Vasquez_Ap1_P2.DAL;
using Eddian_Vasquez_Ap1_P2.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


var connectionString = builder.Configuration.GetConnectionString("SqlConStr");

builder.Services.AddScoped<Aporteservice>();

builder.Services.AddDbContextFactory<Contexto>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddBlazoredToast();

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
