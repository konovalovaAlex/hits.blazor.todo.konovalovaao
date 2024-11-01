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
                new (){ ID = 1, Title="Задание 1", Description="Описание задачи 1", CratedDate=DateTime.Now },
                new (){ ID = 2, Title="Задание 2", Description="Описание задачи 2", CratedDate=DateTime.Now },
                new (){ ID = 3, Title="Задание 3", Description="Описание задачи 3", CratedDate=DateTime.Now },
                new (){ ID = 4, Title="Задание 4", Description="Описание задачи 4", CratedDate=DateTime.Now },
                ]);
        }
    }
}
