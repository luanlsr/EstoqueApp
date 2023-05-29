#region services
using EstoqueApp.API.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRouting(map => map.LowercaseUrls = true);
builder.Services.AddControllers();
builder.Services.AddSwaggerDoc();
builder.Services.AddServices();
builder.Services.AddMediatR();
builder.Services.AddCorsPolicy();

#endregion
#region builder
var app = builder.Build();

app.UseSwaggerDoc();
app.UseCorsPolicy();

app.UseAuthorization();

app.MapControllers();

app.Run();
#endregion