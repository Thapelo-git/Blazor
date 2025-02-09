using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.Options;
using Northwind.EntityModels;
using Microsoft.Extensions.Caching.Memory;
using Northwind.WebApi.Repositories;
using Swashbuckle.AspNetCore.SwaggerUI;
using Microsoft.AspNetCore.HttpLogging;
using System.Net.Http.Headers;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHttpLogging(options =>
{
options.LoggingFields = HttpLoggingFields.All;
options.RequestBodyLogLimit = 4096; // Default is 32k.
options.ResponseBodyLogLimit = 4096; // Default is 32k.
});
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddSingleton<IMemoryCache>(new MemoryCache(new MemoryCacheOptions()));
// Add services to the container.
builder.Services.AddNorthwindContext();
builder.Services.AddControllers(options =>
{
    WriteLine("Default output formatters:");
    foreach (IOutputFormatter formatter in options.OutputFormatters)
    {
        OutputFormatter? mediaFormatter = formatter as OutputFormatter;
        if (mediaFormatter is null)
        {
            WriteLine($"{formatter.GetType().Name}");
        }
        else // OutputFormatter class has SupportedMediaTypes.
        {
            WriteLine("{0}, Media types: {1}",
            arg0: mediaFormatter.GetType().Name,
            arg1: string.Join(", ",
            mediaFormatter.SupportedMediaTypes));
        }
    }
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
// Configure the HTTP request pipeline.

builder.Services.AddHttpClient(name: "Northwind.WebApi",
configureClient: options =>
{
options.BaseAddress = new Uri("https://localhost:5056/");
options.DefaultRequestHeaders.Accept.Add(
new MediaTypeWithQualityHeaderValue(
mediaType: "application/json", quality: 1.0));
});

var app = builder.Build();
app.UseHttpLogging();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "Northwind Service API Version 1");

            c.SupportedSubmitMethods(new[] {
SubmitMethod.Get, SubmitMethod.Post,
SubmitMethod.Put, SubmitMethod.Delete });
        });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
