using Microsoft.EntityFrameworkCore;
using SchoolManager.Models;



public class SchoolManagerContext(DbContextOptions<SchoolManagerContext> options) : DbContext(options)
{
    public DbSet<Classroom> Classrooms { get; set; } = default!;
}



