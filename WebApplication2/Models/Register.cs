using System;

using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;

using System.Linq;

using System.Web;

namespace WebApplication2.Models
{
    public class Register

    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string FName { get; set; }
        [Required]
        public string LName { get; set; }
        [Required]

        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }

        [Required]

        [RegularExpression("[A-Z]{3}[ABCFGHLJPTF]{1}[A-Z]{1}[0-9]{4}[A-Z]{1}", ErrorMessage = "pancard is not valid")]
        public string ValidId { get; set; }



        [Required]

        [RegularExpression("[1-9]{1}[0-9]{9}", ErrorMessage = "Phone no is not valid")]

        public string Phone { get; set; }

        [Required]

        public string Address { get; set; }

        [Required]
        public string Pass { get; set; }
        [Required]
        public string ConfPass { get; set; }

    }
}



