using Microsoft.EntityFrameworkCore;
using proekti.Modules;

namespace student_proekti.Data;

internal class StudentDbContext : DbContext
{
    public StudentDbContext(DbContextOptions options) : base(options)
    {
    }

    public StudentDbContext()
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer("Server=NIAKO;Database=StudentDatabase;Trusted_Connection=True;TrustServerCertificate=True;");
    }

    public DbSet<Student> Students { get; set; }
}
