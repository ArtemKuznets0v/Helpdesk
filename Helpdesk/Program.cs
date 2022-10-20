using Helpdesk.Data;
using Microsoft.AspNetCore.Identity;
using Helpdesk.Interfaces;
using Helpdesk.Models;
using Helpdesk.Repositories;
using Helpdesk.Services;
using Microsoft.EntityFrameworkCore;
using Helpdesk.Controllers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ICompanyService, CompanyService>();
builder.Services.AddScoped<IEmployesService, EmployesService>();
builder.Services.AddScoped<CreateRepozitory>();
builder.Services.AddScoped<IProgramControllerService, ProgramControllerService>();
builder.Services.AddScoped<INotificationControllerService, NotificationControllerService>();
builder.Services.AddScoped<IProgramVersionControllerService, ProgramVersionControllerService>();
builder.Services.AddScoped<IRequestService, RequestService>();

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));


builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddRazorPages().AddRazorRuntimeCompilation();


builder.Services.AddDefaultIdentity<AppUser>(options =>
        {
            options.SignIn.RequireConfirmedAccount = true;
            options.User.RequireUniqueEmail = true;
            options.Password.RequireDigit = true;
            options.Password.RequireLowercase=true;
            options.Password.RequireUppercase=true;
            options.Password.RequireNonAlphanumeric = true;
            options.Password.RequiredUniqueChars = 8;
        }
    ).AddEntityFrameworkStores<ApplicationDbContext>();



builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Company}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Employes}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Program}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Notification}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
   pattern: "{controller=ProgramVers}/{action=Index}/{id?}");
app.MapControllerRoute(
    name: "default",
   pattern: "{controller=Request}/{action=Index}/{id?}");


app.Run();

