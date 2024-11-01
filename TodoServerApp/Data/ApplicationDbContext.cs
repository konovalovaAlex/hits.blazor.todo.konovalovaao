using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TodoServerApp.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public virtual DbSet<TaskItem> TaskItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<TaskItem>().HasData([
                new (){ ID = 1, Title="������� 1", Description="�������� ������ 1", CratedDate=DateTime.Now },
                new (){ ID = 2, Title="������� 2", Description="�������� ������ 2", CratedDate=DateTime.Now },
                new (){ ID = 3, Title="������� 3", Description="�������� ������ 3", CratedDate=DateTime.Now },
                new (){ ID = 4, Title="������� 4", Description="�������� ������ 4", CratedDate=DateTime.Now },
                ]);
        }
    }
}
