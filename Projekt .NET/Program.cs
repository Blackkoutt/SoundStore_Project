using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projekt_.NET.Context;
using Projekt_.NET.Repositories.DbImplementations;
using Projekt_.NET.Repositories.Interfaces;
using Projekt_.NET.Services;
using Projekt_.NET.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddScoped<IAlbumRepository, DbAlbumRepository>();
builder.Services.AddScoped<IAlbumService, AlbumService>();
builder.Services.AddScoped<IAlbum_PerformerRepository, DbAlbum_PerformerRepository>();
builder.Services.AddScoped<IAlbumPerformerService, AlbumPerformerService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICategoryRepository, DbCategoryRepository>();
builder.Services.AddScoped<IPerformerService, PerformerService>();
builder.Services.AddScoped<IPerformerRepository, DbPerformerRepository>();
builder.Services.AddScoped<IProducerService, ProducerService>();
builder.Services.AddScoped<IProducerRepository, DbProducerRepository>();
builder.Services.AddScoped<IDistributorService, DistributorService>();
builder.Services.AddScoped<IDistributorRepository, DbDistributorRepository>();


builder.Services.AddDbContext<ApiContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase"));
});


builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(20);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseSession();

app.MapRazorPages();
app.MapDefaultControllerRoute();

app.Run();
