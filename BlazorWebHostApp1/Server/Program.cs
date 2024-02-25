using BlazorWebHostApp1.Server.DAL;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;

namespace BlazorWebHostApp1
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.

			builder.Services.AddDbContext<EmpDb>(opt=> opt.UseSqlServer("server=.; database= tesEmpDb22; trusted_connection=true; trust server certificate =true;") );




			builder.Services.AddControllersWithViews();
			builder.Services.AddRazorPages();
			builder.Services.AddCors();

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseWebAssemblyDebugging();
			}
			else
			{
				app.UseExceptionHandler("/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();

			app.UseBlazorFrameworkFiles();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseCors(opt =>
			{
				opt.WithOrigins("http://localhost:4200/", "https://localhost:7229/");
				opt.AllowAnyMethod();
				opt.AllowAnyHeader();
			});


			app.MapRazorPages();
			app.MapControllers();
			app.MapFallbackToFile("index.html");

			app.Run();
		}
	}
}
