using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using ToDoList.Models.Containers;

namespace ToDoList.Models
{
    public class ToDoContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options)
        { 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CheckList>()
                .Property(p => p.ListElements)
                .HasConversion(
                    q => JsonSerializer.Serialize(q, (JsonSerializerOptions)default),
                    q => JsonSerializer.Deserialize<List<CheckedListElement>>(q, (JsonSerializerOptions)default));
            modelBuilder.Entity<Note>().HasDiscriminator();
        } 

    }
        
}
