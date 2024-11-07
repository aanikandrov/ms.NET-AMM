
using HistoricalBook.DataAccess;
using HistoricalBook.Settings;

using Microsoft.EntityFrameworkCore;

namespace HistoricalBook.Service.IoC;

public class DbContextConfigurator
{
    public static void ConfigureService(IServiceCollection services, HistoricalBookSettings settings)
    {
        services.AddDbContextFactory<HistoricalBookDbContext>(options =>
        {
            options.UseNpgsql(settings.HistoricalBookDbConnectionString);
        }, ServiceLifetime.Scoped);

    }

    public static void ConfigureApplication(IApplicationBuilder app)
    {
        using var scope = app.ApplicationServices.CreateScope();
        var contextFactory = scope.ServiceProvider.GetRequiredService<IDbContextFactory<HistoricalBookDbContext>>();
        using var context = contextFactory.CreateDbContext();
        context.Database.Migrate();
    }
}