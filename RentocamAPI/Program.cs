using Rentocam.Domain;
using Rentocam.Infra.Contexts;
using Rentocam.Infra.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

CreateInitialDatabase();

builder.Services.AddTransient<RentocamContext>();
builder.Services.AddTransient<IRepository<CameraDetails>, CameraDetailsRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


void CreateInitialDatabase()
{
    using (var context = new RentocamContext())
    {
        context.Database.EnsureDeleted();
        context.Database.EnsureCreated();

        var nikonD90 = new CameraDetails { Id = Guid.NewGuid(), Color = "Black", Manufacturer = "Nikon", ModelName = "D90", Weight = "700 gm", YearOfManufacture = 2007 };
        var nikonD5100 = new CameraDetails { Id = Guid.NewGuid(), Color = "Black", Manufacturer = "Nikon", ModelName = "D5100", Weight = "550 gm", YearOfManufacture = 2011 };

        var cameraDetailsRepository = new CameraDetailsRepository(context);
        cameraDetailsRepository.Add(nikonD90);
        cameraDetailsRepository.Add(nikonD5100);

        cameraDetailsRepository.SaveChanges();
    }
}