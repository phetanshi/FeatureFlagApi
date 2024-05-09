using FeatureFlagApi.AppStart;
using FeatureFlagApi.Endpoints;
using Microsoft.FeatureManagement;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAuthorization();
builder.Services.AddAzureAppConfig(builder.Configuration);
builder.Services.AddFeatureManagement();

var app = builder.Build();

app.UsePipeline();

app.UserWeatherEndpoints();

app.Run();

