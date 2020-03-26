using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;

using System.Linq;

using System.Web;

namespace WebApplication2.Models
{
    public class Room

    {

        [Key]

        public string roomtype { get; set; }



        [Required]

        public Double price { get; set; }

    }

}




