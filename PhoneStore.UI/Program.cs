using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;
using Microsoft.Extensions.Options;
using PhoneStore.UI.Models;
using PhoneStore.UI.Services;

namespace PhoneStore.UI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
           
            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();

            var endpoints = builder.Configuration.GetSection("Endpoints").Get<Endpoints>();
            builder.Services.AddHttpClient("default",
                (c) =>
                {
                    c.BaseAddress = new Uri(endpoints.BaseUrl);
                });

            builder.Services.AddScoped<IOptions<Endpoints>>(_ => new OptionsWrapper<Endpoints>(endpoints));
            builder.Services.AddScoped<IProductsServiceProxy, ProductsServiceProxy>();

            builder.Services
                .AddBlazorise(options =>
                {
                    options.Immediate = true;
                })
                .AddBootstrapProviders()
                .AddFontAwesomeIcons();

            builder.Services.AddScoped(ser => new HttpClient { BaseAddress = new Uri(endpoints.BaseUrl) });

            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.MapControllers();
            app.MapBlazorHub();
            app.MapFallbackToPage("/_Host");

            app.Run();
        }
    }
}