using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using HRM_Plus.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<HRM_PlusContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("HRM_PlusContext") ?? throw new InvalidOperationException("Connection string 'HRM_PlusContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Puestos}/{action=Index}/{id?}");

app.Run();
