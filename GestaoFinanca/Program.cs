var builder = WebApplication.CreateBuilder(args);

// Registra os controllers da aplicação no container de dependencias.
builder.Services.AddControllers();


// Registra a documentação OpenAPI, útil para testar e documentar endpoints.
builder.Services.AddOpenApi();

var app = builder.Build();


// Em ambiente de desenvolvimento, expõe o domencumento OpenAPI. 
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// Redireciona requisições HTTP para HTTPS.
app.UseHttpsRedirection();


// Prepara o middleware de autorização
app.UseAuthorization();


// Mapeia os controllers como endpoints HTTP. 
app.MapControllers();

app.Run();
