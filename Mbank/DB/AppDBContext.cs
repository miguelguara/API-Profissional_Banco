using Microsoft.EntityFrameworkCore;

namespace Mbank.DB
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> option) : base(option)
        {}
    }
}
