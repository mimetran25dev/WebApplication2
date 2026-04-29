var builder = WebApplication.CreateBuilder(args);

// MUST exist
builder.Services.AddControllersWithViews();

var app = builder.Build();

// REMOVE ANY DEFAULT WELCOME PAGE BEHAVIOR
app.UseStaticFiles();
app.UseRouting();

// MVC ROUTE (critical)
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

app.Run();
