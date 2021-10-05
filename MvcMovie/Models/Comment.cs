using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models {
    public class Comment {
        
        public int CommentID {set; get;} // Object primary key

        [Display(Name = "User")]        
        public string UserID {set; get;}

        [Display(Name = "Movie")]        
        public string MovieID {set; get;}

        [Display(Name = "Title")]        
        public string title {set; get;}

        [Display(Name = "Description")]        
        public string description {set; get;}

    }
}