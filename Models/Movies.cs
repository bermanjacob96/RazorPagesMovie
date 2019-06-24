using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
        public class Movie
        {
            public int ID { get; set; } //REQ by Database for primary key
            public string Title { get; set; }
            
            [Display(Name = "Release Date")]
            [DataType(DataType.Date)]
            public DateTime ReleaseDate { get; set; }
            public string Genre { get; set; }

            [Column(TypeName = "decimal(18,2)")]
            public decimal Price { get; set; }
        }
}
