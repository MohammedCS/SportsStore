namespace SportsStore.Extensions;

public static class RegisterServices
{
    public static void Configure(this WebApplicationBuilder builder) 
    {
        builder.Services.AddControllersWithViews();
        builder.Services.AddDbContext<StoreDbContext>(option => 
            option.UseSqlServer(builder.Configuration["ConnectionStrings:AppDb"]));
        builder.Services.AddScoped<IStoreRepository, EFStoreRepository>();
    }
}