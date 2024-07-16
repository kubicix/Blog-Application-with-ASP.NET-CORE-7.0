using BlogApp.Entity;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Data.Concrete.EfCore
{
    public static class SeedData
    {
        public static void TestVerileriniDoldur(IApplicationBuilder app){
            var context = app.ApplicationServices.CreateScope().ServiceProvider.GetService<BlogContext>();
            if(context!=null){
                if(context.Database.GetPendingMigrations().Any())
                {
                    context.Database.Migrate();
                }
                if(!context.Tags.Any()){
                    context.Tags.AddRange(new Tag{Text="web programming",Url="web-programming",Color=TagColors.warning},
                    new Tag{Text="backend",Url="backend",Color=TagColors.info},
                    new Tag{Text="frontend",Url="frontend",Color=TagColors.success},
                    new Tag{Text="fullstack",Url="fullstack",Color=TagColors.secondary},
                    new Tag{Text="php",Url="php",Color=TagColors.primary});
                    context.SaveChanges();
                }
                if(!context.Users.Any()){
                    context.Users.AddRange(
                        new User {
                            UserName="kubilaybirer",Name="Kubilay Birer",Email="info@kb.com",Password="123456",
                            Image="p1.jpg"
                        },
                        new User {
                            UserName="kuzeybirer",Name="Kuzey Birer",Email="info@kb.com",Password="123456",
                            Image="p2.jpg"
                        }
                        
                    );
                    context.SaveChanges();
                }
                if(!context.Posts.Any()){
                    context.Posts.AddRange(new Post {
                        Title="Asp.net Core",
                        Content="Asp.net course complete to get certificated.",
                        Url="aspnet-core",
                        IsActive=true,
                        PublishedOn=DateTime.Now.AddDays(-1),
                        Tags=context.Tags.Take(3).ToList(),
                        Image="1.jpg",
                        UserId=1,
                        Comments=new List<Comment>{
                            new Comment {
                                Text="nice course, keep it up!",
                                PublishedOn=DateTime.Now.AddDays(-20),
                                UserId=1
                            },
                            new Comment {
                                Text="I learned a lot from this course",
                                PublishedOn=DateTime.Now.AddDays(-10),
                                UserId=2
                            }
                        }
                    },
                    new Post {
                        Title="Php Course",
                        Content="Php lessons with codeigniter framework.",
                        Url="php-course",
                        IsActive=true,
                        PublishedOn=DateTime.Now.AddDays(-10),
                        Tags=context.Tags.Take(2).ToList(),
                        Image="2.jpg",
                        UserId=1
                    },
                    new Post {
                        Title="Django Course",
                        Content="Learn python and django at the same time.",
                        Url="django-course",
                        IsActive=true,
                        PublishedOn=DateTime.Now.AddDays(-20),
                        Tags=context.Tags.Take(4).ToList(),
                        Image="3.jpg",
                        UserId=2
                    },
                    new Post {
                        Title="React Course",
                        Content="Learn programming for mobile and web in the same time!",
                        Url="react-course",
                        IsActive=true,
                        PublishedOn=DateTime.Now.AddDays(-30),
                        Tags=context.Tags.Take(4).ToList(),
                        Image="2.jpg",
                        UserId=2
                    },
                    new Post {
                        Title="Angular Course",
                        Content="Learn to code Angular with typescript.",
                        Url="angular-course",
                        IsActive=true,
                        PublishedOn=DateTime.Now.AddDays(-40),
                        Tags=context.Tags.Take(4).ToList(),
                        Image="1.jpg",
                        UserId=2
                    },
                    new Post {
                        Title="Web Design",
                        Content="Learn designing modern web sites with professionals.",
                        Url="web-design",
                        IsActive=true,
                        PublishedOn=DateTime.Now.AddDays(-50),
                        Tags=context.Tags.Take(4).ToList(),
                        Image="3.jpg",
                        UserId=2
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}