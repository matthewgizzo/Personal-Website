using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.IO;

namespace PersonalWebsite.Models
{
    public class Book
    {
        [Key]
        [Column("PK_Id", TypeName = "smallint")]
        public int ID { get; set; }
        
        [Column("Title", TypeName = "varchar(100)")]
        public string Title { get; set; }

        [Column("Author", TypeName = "varchar(50)")]
        public string Author { get; set; }

        [Column("ReleaseDate", TypeName = "datetime")]
        public DateTime ReleaseDate { get; set; }

        [Column("Genre", TypeName = "varchar(50)")]
        public string Genre { get; set; }

        [Column("Series", TypeName = "varchar(100)")]
        public string Series { get; set; }

        [Column("WikipediaLink", TypeName = "varchar(500)")]
        public string WikipediaLink { get; set; }
    }

    public class BookDBContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        /// <summary>
        /// Override the base implementation of OnModelCreating to ensure we have the primary key in the DB table on creation.
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasKey(Book => Book.ID)
                .HasName("PK_Id");

            modelBuilder.Entity<Book>()
                .Property(book => book.ID).IsRequired();

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory()))
                .AddJsonFile("appsettings.json", optional: false)
                .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("BookDBContext"));
        }
    }
}
