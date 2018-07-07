using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;//this line need to be in for validations//this enables use of keywords like MinLength() as parameter like and integer, Range() as 2 integers of two doubles, EmailAddress to verify the field is a valide email address, Compare() to compare two field like confirm password match

namespace formsubmit.Models
{
     public class User
     {
        [Required]
        [MinLength(4)]
        public string First_Name { get; set; }

        [Required]
        [MinLength(4)]
        public string Last_Name { get; set; }

        [Required]
        [Range(1,99)]
        public int Age { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
     }
}