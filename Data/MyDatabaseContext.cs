using DotNetAzure.Models;
using Microsoft.EntityFrameworkCore;
    public class MyDatabaseContext : DbContext
    {
        public MyDatabaseContext (DbContextOptions<MyDatabaseContext> options)
            : base(options)
        {
        }
        public DbSet<Todo> Todo { get; set; }
    }
	