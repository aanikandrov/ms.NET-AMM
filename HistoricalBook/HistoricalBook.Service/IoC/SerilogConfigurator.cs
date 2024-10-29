﻿using Serilog;

namespace HistoricalBook.Service.IoC;
 
public static class SerilogConfigurator
{
    public static void ConfigureService(WebApplicationBuilder builder)
    {
        builder.Host.UseSerilog((context, configuration) =>
        {
            configuration
                .Enrich.WithCorrelationId()
                .ReadFrom.Configuration(context.Configuration);
        });

        builder.Services.AddHttpContextAccessor();
    }

    public static void ConfigureApplication(IApplicationBuilder app)
    {
        app.UseSerilogRequestLogging();
    }
}