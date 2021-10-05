using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models {
    public class Rent {
        
        public int RentID {set; get;} // Object primary key

        [Display(Name = "Rent Start Date"), DataType(DataType.Date)]
        public DateTime rentStartDate {set; get;}

        [Display(Name = "Rent End Date"), DataType(DataType.Date)]
        public DateTime rentEndDate {set; get;}

        [Display(Name = "User")]
        public string UserID;

        [Display(Name = "Price"), Column(TypeName = "money")]
        public decimal price {set; get;}

        [Display(Name = "Movies")]
        public ICollection<Movie> movies {set; get;}

    }
}