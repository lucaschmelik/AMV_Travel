using AMV_Travel.DataAccess.Context;
using AMV_Travel.Services.Kafka.Interface;
using AMV_Travel.Services.Kafka.ProducerSingleton;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AMVContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddSingleton<IKafkaProducer, KafkaProducer>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

using var serviceScope = app.Services.CreateScope();
using var context = serviceScope.ServiceProvider.GetRequiredService<AMVContext>();


#if !DEBUG
context.Database.Migrate();
#endif

app.UseAuthorization();

app.MapControllers();

app.Run();
