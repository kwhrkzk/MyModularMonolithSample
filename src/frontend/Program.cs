using frontend.Components;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using modularA;
using modularB;
using shared.modularA;
using shared.modularB;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddGrpc();
builder.Services.AddMagicOnion();
builder.WebHost.UseKestrel(options =>
{
    options.ConfigureEndpointDefaults(endpointOptions =>
    {
        endpointOptions.Protocols = HttpProtocols.Http2;
    });
});

builder.Services.AddTransient<IModularAUsecase, ModularAUsecase>();
builder.Services.AddTransient<IModularBUsecase, ModularBUsecase>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.MapMagicOnionService();
app.Run();
