﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace WebApplication2.Models
{
    public partial  class Register
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [EmailAddress]
        [StringLength(150)]
        [Display(Name = "Email Address: ")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(150, MinimumLength = 6)]
        [Display(Name = "Password: ")]
        public string Password { get; set; }

        public string PasswordSalt { get; set; }

        [Required]
        [Display(Name = "First Name: ")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name: ")]
        public string LastName { get; set; }
        public string UserType { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
        public string IPAddress { get; set; }
        [Required]

        [RegularExpression("[A-Z]{3}[ABCFGHLJPTF]{1}[A-Z]{1}[0-9]{4}[A-Z]{1}", ErrorMessage = "pancard is not valid")]
        public string ValidId { get; set; }
        [Required]
        [RegularExpression("[1-9]{1}[0-9]{9}", ErrorMessage = "Phone no is not valid")]
        public string Phone { get; set; }

        [Required]
        public string Address { get; set; }
    }
}