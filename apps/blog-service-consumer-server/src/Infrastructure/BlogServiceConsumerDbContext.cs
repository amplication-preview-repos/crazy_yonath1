using Microsoft.EntityFrameworkCore;

namespace BlogServiceConsumer.Infrastructure;

public class BlogServiceConsumerDbContext : DbContext
{
    public BlogServiceConsumerDbContext(DbContextOptions<BlogServiceConsumerDbContext> options)
        : base(options) { }
}
