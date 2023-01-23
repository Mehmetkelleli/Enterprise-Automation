using isteksikayet.Entity;
using isteksikayet.webui.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Task = isteksikayet.Entity.Task;

namespace isteksikayet.Data.Context
{
    public class DataContext:IdentityDbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Complaint> Complaints { get; set; }
        public DbSet<ComplaintReply> ComplaintReplays { get; set; }
        public DbSet<SiteConfig> Setting { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=localhost\\SQLEXPRESS;Database=DataDb;MultipleActiveResultSets=true;Integrated Security=True");
        }

    }
}
