using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace MyWebsite.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

    }
}


