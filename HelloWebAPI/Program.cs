using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Service (Container)
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

if (app.Environment.IsDevelopment()) //�evre de�i�kenleri Development modunda ise
{
    app.UseSwagger();
    app.UseSwaggerUI();

}


app.MapControllers();

//app.MapGet("/", () => "Hello World!");

app.Run();
