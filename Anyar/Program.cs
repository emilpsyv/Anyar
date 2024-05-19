using Anyar.DAL;
using Microsoft.EntityFrameworkCore;

namespace Anyar
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AnyarContext>(opt=>opt.UseSqlServer(builder.Configuration.GetConnectionString("CodeFirst")));
            var app = builder.Build();
            app.UseStaticFiles();

            app.MapControllerRoute("areas", "{area:exists}/{controller=Employee}/{action=Index}/{id?}");

            app.MapControllerRoute("Default" ,"{controller=Home}/{action=Index}/{id?}" );

            app.Run();
        }
    }
}
