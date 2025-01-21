using Microsoft.EntityFrameworkCore;
using TravelBlog.Models;

namespace TravelBlog.Data
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AppDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
            {
                if (context.Posts.Any())
                {
                    return;
                }

                context.Posts.AddRange(
                    new Post
                    {
                        Title = "Eerste Post",
                        Content = "Dit is de inhoud van de eerste post.",
                        Author = "Auteur1",
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                        IsPublished = true
                    },
                    new Post
                    {
                        Title = "Tweede Post",
                        Content = "Dit is de inhoud van de tweede post.",
                        Author = "Auteur2",
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                        IsPublished = false
                    },
                    new Post
                    {
                        Title = "Derde Post",
                        Content = "Dit is de inhoud van de derde post.",
                        Author = "Auteur3",
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                        IsPublished = true
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
