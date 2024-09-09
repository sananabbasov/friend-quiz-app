using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QuizApp.Entities.Concrete;

namespace QuizApp.DataAccess.Concrete.EntityFramework;

public class AppDbContext : DbContext
{
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=127.0.0.1,1433;Database=K232FriendQuizDb; User Id=SA; Password=Ehmed123; TrustServerCertificate=True;");
    }

    public DbSet<Answer> Answers { get; set; }
    public DbSet<Friend> Friends { get; set; }
    public DbSet<Quiz> Quizzes { get; set; }
    public DbSet<UserAnswer> UserAnswers { get; set; }
    public DbSet<User> Users { get; set; }

      protected override void OnModelCreating(ModelBuilder builder)
    {

        builder.Entity<UserAnswer>()
        .HasOne(x => x.Quiz)
        .WithMany()
        .OnDelete(DeleteBehavior.Restrict);

    }
}
