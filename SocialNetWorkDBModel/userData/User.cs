using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SocialNetWorkDBModel.userData.groups;
using SocialNetWorkDBModel.userData.professions;

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
        //[Required]
        //public virtual UserData UserData { get; set;}
        [MaxLength(100)]
        [Required]
        [Index(name: "UniqueName", IsUnique = true)]
        public string Login { get; set; }
        [MaxLength(12)]
        [Required]
        public string Password { get; set; }
        public string UserAvatarUrl { get; set; }
        public string UserMail { get; set; }
        public Professions Profession { get; set; }
        public ICollection<NetWorkGroup> UserGroup { get; set; }
        [Required]
        public SexEnum Sex { get; set; }
        [Required]
        public StatesEnum StateId { get; set; }
    }
}
