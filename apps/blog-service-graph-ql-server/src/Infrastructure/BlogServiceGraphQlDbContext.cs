using Microsoft.EntityFrameworkCore;

namespace BlogServiceGraphQl.Infrastructure;

public class BlogServiceGraphQlDbContext : DbContext
{
    public BlogServiceGraphQlDbContext(DbContextOptions<BlogServiceGraphQlDbContext> options)
        : base(options) { }
}
