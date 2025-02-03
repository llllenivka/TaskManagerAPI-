using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using TaskManager.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
// builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlite("Data Source=tasks.db"));

var app = builder.Build();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
