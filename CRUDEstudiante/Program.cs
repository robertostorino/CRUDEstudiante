using CRUDEstudiante.Context;
using Microsoft.EntityFrameworkCore;

namespace CRUDEstudiante
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            // Aqu� indico que la aplicaci�n usar� los servicios de EF
            // con una base de datos Sql Server y le paso la info de la cadena de conexi�n

            builder.Services.AddDbContext<EscuelaDatabaseContext>(options =>
                                options.UseSqlServer(builder.Configuration["ConnectionString:EscuelaDBConnection"]));

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
