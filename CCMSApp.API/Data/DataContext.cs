using CCMSApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CCMSApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}
        public DbSet<User> Users {get; set;}
        public DbSet<Customer> Customers {get; set;}
        public DbSet<Category> Categories {get; set;}
        public DbSet<Ticket> Tickets {get; set;}
        public DbSet<Reference> References {get; set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().
                HasOne(e => e.GroupMembership).
                WithMany().
                HasForeignKey(m => m.MemberOf);

            modelBuilder.Entity<User>().
                HasOne(e => e.Manager).
                WithMany().
                HasForeignKey(m => m.Superior);

            modelBuilder.Entity<User>().
                HasOne(e => e.Author).
                WithMany().
                HasForeignKey(m => m.CreatedBy);

            modelBuilder.Entity<User>().
                HasOne(e => e.Editor).
                WithMany().
                HasForeignKey(m => m.ModifiedBy);

            modelBuilder.Entity<Customer>()
                .HasOne(m => m.Author)
                .WithMany(t => t.CustomersCreated)
                .HasForeignKey(m => m.CreatedBy)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Customer>()
                .HasOne(m => m.Editor)
                .WithMany(t => t.CustomersModified)
                .HasForeignKey(m => m.ModifiedBy)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Category>().
                HasOne(e => e.ParentCategory).
                WithMany().
                HasForeignKey(m => m.ParentId);

            modelBuilder.Entity<Category>()
                .HasOne(m => m.Author)
                .WithMany(t => t.CategoriesCreated)
                .HasForeignKey(m => m.CreatedBy)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Category>()
                .HasOne(m => m.Editor)
                .WithMany(t => t.CategoriesModified)
                .HasForeignKey(m => m.ModifiedBy)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Ticket>()
                .HasOne(m => m.Author)
                .WithMany(t => t.TicketsCreated)
                .HasForeignKey(m => m.CreatedBy)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Ticket>()
                .HasOne(m => m.Editor)
                .WithMany(t => t.TicketsModified)
                .HasForeignKey(m => m.ModifiedBy)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Ticket>()
                .HasOne(m => m.Type)
                .WithMany(t => t.TicketType)
                .HasForeignKey(m => m.TypeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Ticket>()
                .HasOne(m => m.Category)
                .WithMany(t => t.TicketCategory)
                .HasForeignKey(m => m.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Ticket>()
                .HasOne(m => m.SubCategory)
                .WithMany(t => t.TicketSubCategory)
                .HasForeignKey(m => m.SubCategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Ticket>()
                .HasOne(m => m.DetailCategory)
                .WithMany(t => t.TicketDetailCategory)
                .HasForeignKey(m => m.DetailCategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Ticket>().
                HasOne(e => e.Customer).
                WithMany().
                HasForeignKey(m => m.CustomerId);
            
            modelBuilder.Entity<Reference>()
                .HasKey(k => new {k.ParentTicketId, k.ChildTicketId});

            modelBuilder.Entity<Reference>()
                .HasOne(u => u.ChildTicket)
                .WithMany(u => u.ParentTickets)
                .HasForeignKey(u => u.ChildTicketId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Reference>()
                .HasOne(u => u.ParentTicket)
                .WithMany(u => u.ChildTickets)
                .HasForeignKey(u => u.ParentTicketId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Reference>()
                .HasOne(m => m.Author)
                .WithMany(t => t.ReferencesCreated)
                .HasForeignKey(m => m.CreatedBy)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Reference>()
                .HasOne(m => m.Editor)
                .WithMany(t => t.ReferencesModified)
                .HasForeignKey(m => m.ModifiedBy)
                .OnDelete(DeleteBehavior.Restrict);

           

          


        }
    }
}