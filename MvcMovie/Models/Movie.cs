using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models {
    public class Movie {
        
        public int MovieID {set; get;} // Object primary key

        [Display(Name = "Title")]
        public string title {set; get;}

        [Display(Name = "Genre")]
        public string genre {set; get;}

        [Display(Name = "Price"), Column(TypeName = "money")]
        public decimal price {set; get;}

        [Display(Name = "Release Date"), DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime releaseDate {set; get;}

        [Display(Name = "Rate")]
        public float rate {set; get;} = 0;

        [Display(Name = "Status")]
        public bool status {set; get;}

        [Display(Name = "Comments")]
        public ICollection<Comment> comments {set; get;}

        [Display(Name = "Rents")]
        public ICollection<Rent> rents {set; get;}

    }
}