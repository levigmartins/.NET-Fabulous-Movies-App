using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models {
    public class Rent {
        
        public int id {set; get;} // Object primary key

        [Display(Name = "Rent Start Date")]
        [DataType(DataType.Date)]
        public DateTime rentStartDate {set; get;}

        [Display(Name = "Rent End Date")]
        [DataType(DataType.Date)]
        public DateTime rentEndDate {set; get;}

        [Display(Name = "User")]
        public string user;

        [Display(Name = "Price")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal price {set; get;}

        [Display(Name = "Movies")]
        public List<Movie> movies {set; get;}

    }
}