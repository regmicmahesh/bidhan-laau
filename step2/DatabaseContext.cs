

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

public class User
{
    [Key]
    public int CourseID { get; set; }


    [Required]
    public string? Name {get; set;}
}

public class UserContext : DbContext
{

    public UserContext(DbContextOptions<UserContext> options) : base(options)
    {

    }

    public DbSet<User> Users => Set<User>();
}