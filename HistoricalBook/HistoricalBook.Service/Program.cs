

using HistoricalBook.Service.IoC;
using HistoricalBook.Settings;

var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", optional: false)
    .Build();

var settings = HistoricalBookSettingsReader.Read(configuration);

var builder = WebApplication.CreateBuilder(args);

SerilogConfigurator.ConfigureService(builder);
DbContextConfigurator.ConfigureService(builder.Services, settings);
SwaggerConfigurator.ConfigureServices(builder.Services);

var app = builder.Build();

SerilogConfigurator.ConfigureApplication(app);
SwaggerConfigurator.ConfigureApplication(app);
DbContextConfigurator.ConfigureApplication(app);

app.UseHttpsRedirection();

app.Run();