using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models {
    public class Movie {
        
        public int id {set; get;} // Object primary key

        [Display(Name = "Title")]
        public string title {set; get;}

        [Display(Name = "Genre")]
        public string genre {set; get;}

        [Display(Name = "Price")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal price {set; get;}

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime releaseDate {set; get;}

    }
}