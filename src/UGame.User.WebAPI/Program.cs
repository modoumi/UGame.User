using AiUo;
//using AiUo.AppMetric;
using AiUo.Configuration;

var builder = AspNetHost.CreateBuilder();

builder.AddAspNetEx();
//builder.UseXxyyApiServer();

var app = builder.Build();

app.UseAspNetEx();

app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();
