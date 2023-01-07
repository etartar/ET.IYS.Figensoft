using ET.IYS.Figensoft.Abstract;
using ET.IYS.Figensoft.Api.Configurations;
using ET.IYS.Figensoft.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var section = builder.Configuration.GetSection("IYSConfig");
builder.Services.Configure<IYSConfig>(section);

builder.Services.AddHttpClient();
builder.Services.AddScoped<IIYSConfiguration, IYSConfiguration>();
builder.Services.AddScoped<IIYSServiceAdapter, IYSServiceApiAdapter>();

builder.Services.AddAutoMapper(typeof(Program));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
