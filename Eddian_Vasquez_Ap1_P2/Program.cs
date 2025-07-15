using Blazored.Toast;
using Eddian_Vasquez_Ap1_P2.Components;
using Eddian_Vasquez_Ap1_p2.Context;
using Eddian_Vasquez_Ap1_p2.Services;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("SqlConStr");

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddScoped<EntradasService>();
builder.Services.AddScoped<ProductosService>();

builder.Services.AddDbContextFactory<Contexto>(options =>
options.UseSqlServer(connectionString));

builder.Services.AddBlazoredToast();

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();