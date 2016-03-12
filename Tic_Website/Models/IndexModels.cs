using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tic_Website.Models
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public class IndexModels
    {
        [Required(ErrorMessage = "Please Enter Name")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is Requirde")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                            ErrorMessage = "Email is not valid")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter Flight Number")]
        [Display(Name = "Flight")]
        public string Flight { get; set; }

        [Required(ErrorMessage = "Please Enter Arrive Date")]
        [DataType(DataType.Date)]
        public string Date { get; set; }

        public string Request { get; set; }
    }
}