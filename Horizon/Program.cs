var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}

app.UseBlazorFrameworkFiles();
app.MapStaticAssets();

app.UseHttpsRedirection();

app.UseRouting();

app.MapFallbackToFile("index.html");

app.Run();
