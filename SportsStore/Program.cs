var builder = WebApplication.CreateBuilder(args);

builder.Configure();

var app = builder.Build();

app.UseStaticFiles();
app.MapDefaultControllerRoute();

SeedData.EnsuredPopulated(app);

app.Run();
