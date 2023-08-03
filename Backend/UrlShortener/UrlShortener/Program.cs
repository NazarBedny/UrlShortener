using BLL;
using DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Add Dependency injection
builder.Services.AddBLL();

// Connection database
builder.Services.AddDbContext<UrlShortenerContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddCors(o=>o.AddPolicy("FrontEnd",police =>
{
    police.AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader();
}));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseCors("FrontEnd");

app.MapControllers();

app.MapFallback(async (UrlShortenerContext _context, HttpContext ctx) =>
{
    var path = ctx.Request.Path.ToUriComponent().Trim('/');
    var urlMatch = await _context.UrlModels.FirstOrDefaultAsync(x => x.ShortenedURL == path);
    if (urlMatch == null)
    {
        return Results.BadRequest();
    }
    return Results.Redirect(urlMatch.OriginalURL);

});
app.Run();
