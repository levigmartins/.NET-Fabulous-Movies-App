using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models {
    public class Rent {
        
        public int id {set; get;} // Object primary key

        [Display(Name = "User")]        
        public string userID {set; get;}

        [Display(Name = "Title")]        
        public string title {set; get;}

        [Display(Name = "Description")]        
        public string description {set; get;}

    }
}