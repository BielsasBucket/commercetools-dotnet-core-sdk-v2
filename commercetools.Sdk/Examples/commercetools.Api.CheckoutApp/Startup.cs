using commercetools.Api.CheckoutApp.Extensions;
using commercetools.Api.CheckoutApp.Services;
using commercetools.Base.Client;
using commercetools.Base.Client.Tokens;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace commercetools.Api.CheckoutApp
{
    public class Startup
    {
        private readonly IConfiguration configuration;

        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
            var clientConfiguration = configuration.GetSection("SPAClient").Get<ClientConfiguration>();
            Settings.ProjectKey = clientConfiguration.ProjectKey;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.UseCommercetoolsScopedClient(configuration, "SPAClient");
            services.AddScoped<CartServices>();
            services.AddScoped<ProductServices>();
            services.AddSession();
            services.AddControllersWithViews();
            services.AddMvc();
            services.AddHttpContextAccessor();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseSession();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}