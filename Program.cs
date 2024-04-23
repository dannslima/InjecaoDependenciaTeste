using InjecaoDependenciaTeste;
using Microsoft.Extensions.DependencyInjection;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Registrar as implementações para as interfaces com os escopos apropriados
builder.Services.AddTransient<IoperacaoTransient, Operacao>();
builder.Services.AddScoped<IoperacaoSccoped, Operacao>();
builder.Services.AddSingleton<IoperacaoSingleton, Operacao>();

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
