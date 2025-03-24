using Artpiece;
using Artpiece.Reposatory.ArtpieceRepo;
using Artpiece.Reposatory.CategoryRepo;
using Artpiece.Reposatory.CustomerRepo;
using Artpiece.Reposatory.LoyaltyRepo;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<Appdbcontext>(p=>p.UseSqlServer(builder.Configuration.GetConnectionString("data")));
builder.Services.AddScoped<ICustomer, Customerrepo>();
builder.Services.AddScoped<Icategory, Categoryrepo>();
builder.Services.AddScoped<IArtpiece, Artpiecerepo>();
builder.Services.AddScoped<ILoyalty, Loyaltyrepo>();




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
