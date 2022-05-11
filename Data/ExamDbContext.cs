using Domain;
using Microsoft.EntityFrameworkCore;

namespace Data;

public class ExamDbContext : DbContext
{
    private readonly string _connectionString;

    protected ExamDbContext(string connectionString = "")
    {
        _connectionString = connectionString;
    }

    public ExamDbContext(DbContextOptions options) : base(options)
    {
        
    }
    
    public DbSet<User> Users { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Game> Games { get; set; }
}