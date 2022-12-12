using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ProiectWAD.Interfaces.Repository;
using ProiectWAD.Models;
using ProiectWAD.Repository;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

builder.Services.AddDbContext<ProiectWADDBContext>(options =>
    options.UseSqlServer(connectionString)); ;

builder.Services.AddDefaultIdentity<User>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ProiectWADDBContext>();
builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequiredLength = 4;

    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);

    options.User.RequireUniqueEmail = true;
});


// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddDbContext<ProiectWADDBContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection")),
    ServiceLifetime.Transient);

builder.Services.AddScoped<IUsersRepository, UsersRepository>();
builder.Services.AddScoped<ISellersRepository, SellersRepository>();
builder.Services.AddScoped<IProductsRepository, ProductsRepository>();
builder.Services.AddScoped<ICategoriesRepository, CategoriesRepository>();

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
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();
app.Run();
