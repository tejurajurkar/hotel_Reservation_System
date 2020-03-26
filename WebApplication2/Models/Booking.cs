

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

        public string Email { get; set; }

        [Required]

        public string roomtype { get; set; }



        [Required]

        public DateTime checkin { get; set; }

        [Required]

        public int noofnight { get; set; }



    }

}
