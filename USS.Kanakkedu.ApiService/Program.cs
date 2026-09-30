using Microsoft.EntityFrameworkCore;
using USS.Kanakkedu.Business;
using USS.Kanakkedu.Business.Interface;
using USS.Kanakkedu.Data;
using USS.Kanakkedu.Data.Interface;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Add service defaults & Aspire client integrations.
builder.AddServiceDefaults();

// Add services to the container.
builder.Services.AddProblemDetails();

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddDbContext<KanakkeduDBContext>(option => { 

        option.UseSqlServer(builder.Configuration.GetConnectionString("KanakkeduDBConnection"));

});

builder.Services.AddScoped<IFundData, FundData>();
builder.Services.AddScoped<IFundBusiness, FundBusiness>();

builder.Services.AddScoped<IJournalTypeData, JournalTypeData>();
builder.Services.AddScoped<IJournalTypeBusiness, JournalTypeBusiness>();


var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseExceptionHandler();

app.MapControllers();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}


app.MapDefaultEndpoints();

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
