using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

public class Startup
{
    // Bu metot, hizmetleri (services) ve middleware'leri yapılandırmak için kullanılır.
    public void ConfigureServices(IServiceCollection services)
    {
        // controllers ve views için servisleri ekleyin
        services.AddControllersWithViews();
    }

    // Bu metot, HTTP isteği işleme pipeline'ını yapılandırmak için kullanılır.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        });
    }
}
