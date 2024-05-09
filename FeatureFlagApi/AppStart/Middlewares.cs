namespace FeatureFlagApi.AppStart;

public static class Middleware
{
    public static void UsePipeline(this WebApplication app)
    {
        app.UseSwagger();
        app.UseSwaggerUI();
        app.UseHttpsRedirection();
        app.UseAzureAppConfiguration();
        app.UseAuthorization();
    }
}
