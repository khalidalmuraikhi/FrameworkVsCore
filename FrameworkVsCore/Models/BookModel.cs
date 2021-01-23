using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FrameworkVsCore.Models
{
    public class BookModel
    {

        [Display(Name = "Title")]
        [Required(ErrorMessage = "Please Include a Title")]
        public string Title { get; set; }
        [Display(Name = "Price")]
        [Required(ErrorMessage = "Please Include Price")]
        [Range (1,999999, ErrorMessage = "Price must be between 1 and 999999")]
        public int Price { get; set; }
    }
}