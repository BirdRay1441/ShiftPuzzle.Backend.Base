
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore; 

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<CompanionContext>(options =>
        options.UseSqlite("Data Source=CompanionDataBase.db"));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddSingleton<ICompanionManager>(provider =>
{
    var companionOptionsBuilder = new DbContextOptionsBuilder<CompanionContext>();
    companionOptionsBuilder.UseSqlite("Data Source=CompanionDataBase.db"); 
    var companionContext = new CompanionContext(companionOptionsBuilder.Options);
    companionContext.Database.EnsureCreated();
    ICompanionRepository CompanionRepository = new CompanionRepository(companionContext);
    ICompanionManager companionManager = new CompanionManager(CompanionRepository);

    return companionManager;
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAuthorization();

app.MapControllers();

app.Run();