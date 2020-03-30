

using System;

using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;

using System.Linq;

using System.Web;



namespace WebApplication2.Models

{

    public class Booking

    {

        [Key]

        public int bookingid { get; set; }

        [Required]

        public string Name { get; set; }

        [Required]
        

        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        
        public string Email { get; set; }

        [Required]

        public string roomtype { get; set; }



        [Required]

        public string checkin { get; set; }

        [Required]

        public string noofnight { get; set; }



    }

}
