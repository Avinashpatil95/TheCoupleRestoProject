using Microsoft.EntityFrameworkCore;
using RestaurantWebsite.Data;

var builder = WebApplication.CreateBuilder(args);

// SQLite database
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite("Data Source=restaurant.db"));

// Add services
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddSession(); // enable session for login

var app = builder.Build();

// Middleware
app.UseStaticFiles();
app.UseRouting();
app.UseSession();
app.UseAuthorization();

// Routing
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

var port = Environment.GetEnvironmentVariable("PORT") ?? "10000";
app.Urls.Add($"http://0.0.0.0{port}");

app.Run();