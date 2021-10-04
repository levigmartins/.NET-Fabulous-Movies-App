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

        [Display(Name = "Rate")]
        [Column(TypeName = "")]
        public float rate {set; get;} = 0;

        [Display(Name = "Status")]
        public boolean status {set; get;}

        [Display(Name = "Comments")]
        public List<Comment> comments {set; get;}

        [Display(Name = "Rents")]
        public List<Rent> rents {set; get;}

    }
}