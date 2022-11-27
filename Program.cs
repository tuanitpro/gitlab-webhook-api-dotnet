using System.IO.Compression;
using System.Net;
using beeWebHooksAPI;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseKestrel().ConfigureKestrel((context, options) =>
{
    options.Listen(IPAddress.Any, 5009, listenOptions =>
    {
        // Use HTTP/3
        listenOptions.Protocols = HttpProtocols.Http1AndHttp2;
        // listenOptions.UseHttps();
    });
    options.AddServerHeader = false;
});

var services = builder.Services;
services.AddResponseCompression();

services.Configure<TelegramOptions>(builder.Configuration.GetSection(nameof(TelegramOptions)));
services.AddSingleton<ITelegramOptions>(sp =>
   sp.GetRequiredService<IOptions<TelegramOptions>>().Value);

services.AddResponseCompression(options =>
{
    options.Providers.Add<BrotliCompressionProvider>();
    options.Providers.Add<GzipCompressionProvider>();
});
services.Configure<GzipCompressionProviderOptions>(options =>
{
    options.Level = CompressionLevel.Fastest;
});


services.AddControllers().AddNewtonsoftJson(options => options.SerializerSettings.ContractResolver = new DefaultContractResolver());
services.AddHealthChecks();

var app = builder.Build();
app.UseResponseCompression();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    // app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();
app.MapControllers();
app.MapHealthChecks("/health");

app.Run();