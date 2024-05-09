using Azure.Identity;

namespace FeatureFlagApi.AppStart;

public static class AppConfig
{
    public static void AddAzureAppConfig(this IServiceCollection services, IConfigurationManager configuration)
    {
        string connectionString = configuration.GetConnectionString("AppConfig") ?? "";

        if(!string.IsNullOrEmpty(connectionString))
        {
            configuration.AddAzureAppConfiguration(options =>
            {
                options.Connect(connectionString);
                //options.Connect(new Uri("https://ps-az-app-config.azconfig.io"), new DefaultAzureCredential());
                options.UseFeatureFlags();
            });
        }

        services.AddAzureAppConfiguration();
    }
}
