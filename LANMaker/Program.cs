using ElectronNET.API;
using LANMaker;


var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseElectron(args);

Startup.ConfigureServices(builder.Services);

//builder.Host.ConfigureWebHostDefaults(webBuilder =>
//{
//    //webBuilder.UseElectron(args);
//    //webBuilder.UseStartup<Startup>();
//});

//var builder = CreateHostBuilder(args);

// Add services to the container

builder.Services.AddControllersWithViews();

var app = builder.Build();

Startup.Configure(app, app.Environment);

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

app.Run();
