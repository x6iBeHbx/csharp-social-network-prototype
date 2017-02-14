using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SocialNetWorkDBModel.userData
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [MaxLength(300)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(300)]
        public string SecondName { get; set; }
        public DateTime BirthDate { get; set; }
        [Required]
        public virtual UserData UserData { get; set;}
    }
}
