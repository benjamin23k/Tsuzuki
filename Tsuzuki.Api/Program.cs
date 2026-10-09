using Tsuzuki.Infrastructure.External_Apis.MangaDex;

var builder = WebApplication.CreateBuilder(args);

Uri mangaDexApiBaseUri = new("https://api.mangadex.org/");

builder.Services.AddHttpClient<MangaDexProvider>(client =>
{
    client.BaseAddress = mangaDexApiBaseUri;
    client.DefaultRequestHeaders.Add("User-Agent", "Tsuzuki");
});

var app = builder.Build();



app.UseHttpsRedirection();



app.Run();



