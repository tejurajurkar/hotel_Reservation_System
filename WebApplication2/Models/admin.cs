using System;

using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;

using System.Linq;

using System.Web;

namespace WebApplication2.Models
{
    public class admin
    {
        [Key]

        public int adminid { get; set; }



        [Required]

        public string adminname { get; set; }

        [Required]

        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]



        public string email { get; set; }

        [Required]

        [RegularExpression("[1-9]{1}[0-9]{9}", ErrorMessage = "Phone no is not valid")]



        public string phone { get; set; }

        [Required]



        public string pass { get; set; }



        [Required]

        public string confpass { get; set; }



    }

}




