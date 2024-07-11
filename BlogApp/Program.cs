using BlogApp.Data.Abstract;
using BlogApp.Data.Concrete;
using BlogApp.Data.Concrete.EfCore;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<BlogContext>(options =>{
    
    options.UseSqlite(builder.Configuration["ConnectionStrings:Sql_connection"]);
});

builder.Services.AddScoped<IPostRepository,EfPostRepository>();
builder.Services.AddScoped<ITagRepository,EfTagRepository>();

var app = builder.Build();
SeedData.TestVerileriniDoldur(app);

app.UseStaticFiles();

//localhost://posts/react-course
//localhost://posts/tag/web-design
//...

app.MapControllerRoute(
    name: "post_details",
    pattern: "posts/{url}",
    defaults: new {controller="Posts",Action="Details"}
);

app.MapControllerRoute(
    name: "posts_by_tag",
    pattern: "posts/tag/{tag}",
    defaults: new {controller="Posts",Action="Index"}
);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
