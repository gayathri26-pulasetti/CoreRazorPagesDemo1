using CoreRazorPagesDemo1.Models;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container
        builder.Services.AddRazorPages();
        builder.Services.AddDbContext<MvcdbContext>();

        var app = builder.Build();

          

        // Configure the HTTP request pipeline
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();

        app.UseStaticFiles();   // ✅ Correct for static files

        app.UseRouting();

        app.UseAuthorization();

        app.MapRazorPages().WithStaticAssets();  // ✅ Correct

        app.Run();
    }
}