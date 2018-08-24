using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebMVC.Models
{
    public class Movie
    {
        public int ID { get; set; }
    
        [StringLength(30,MinimumLength=6)]
        public string Title {get;set;}
       
        [Display(Name="Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString="{0:yyyy/MM/dd}",ApplyFormatInEditMode=true)]
        public DateTime ReleaseDate {get;set;}

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        [StringLength(30)]
        public string Genre {get;set;}

        [DataType(DataType.Currency)]
        [Range(1,100)]
        public decimal Price { get; set; }

    }
    public class MovieDBContent : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}