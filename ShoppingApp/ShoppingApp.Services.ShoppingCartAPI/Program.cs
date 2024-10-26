
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ShoppingApp.Services.ShoppingCartAPI.Data;
using ShoppingApp.Services.ShoppingCartAPI.Service.IService;
using ShoppingApp.Services.ShoppingCartAPI.Service;

namespace ShoppingApp.Services.ShoppingCartAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<AppDbContext>(Options =>
            {
                Options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
            });


            IMapper mapper = MappingConfig.RegisterMaps().CreateMapper();
            builder.Services.AddSingleton(mapper);
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


            builder.Services.AddScoped<IProductService, ProductService>();

            builder.Services.AddHttpClient("Product",
            u => u.BaseAddress = new Uri(builder.Configuration["ServiceUrls:ProductAPI"])); 

            builder.Services.AddControllers();


            builder.Services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                {
                    builder.AllowAnyOrigin()
                           .AllowAnyMethod()
                           .AllowAnyHeader();
                });
            });

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection(); 
            app.UseAuthorization();
            app.UseCors("CorsPolicy");
            app.MapControllers();
            ApplyMigration();
            app.Run();


            void ApplyMigration()
            {
                using (var scope = app.Services.CreateScope())
                {
                    var _db = scope.ServiceProvider.GetRequiredService<AppDbContext>();

                    if (_db.Database.GetPendingMigrations().Count() > 0)
                    {
                        _db.Database.Migrate();
                    }
                }
            }
        }
    }
}
