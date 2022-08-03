using ArticleAPIExample.Model;
using Microsoft.EntityFrameworkCore;

namespace ArticleAPIExample.Data
{
    public class ConnectionDbContext:DbContext
    {
        public ConnectionDbContext(DbContextOptions options):base(options)
        {


        }
        public DbSet<SaleData> saleData { get; set; }
    }
}
