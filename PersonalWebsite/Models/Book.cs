using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalWebsite.Models
{
    public class Book
    {
        [Key]
        [Column("Id", TypeName = "bit")]
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
    }
}
