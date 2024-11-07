namespace HistoricalBook.Settings;

public class HistoricalBookSettingsReader
{
    public static HistoricalBookSettings Read(IConfiguration configuration)
    {
        return new HistoricalBookSettings()
        {
            HistoricalBookDbConnectionString = configuration.GetValue<string>("HistoricalBookDbContext")
        };
    }
}