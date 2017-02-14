using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialNetWorkDBModel.userData.professions;

namespace SocialNetWorkDBModel.userData
{
    public class UserData
    {
       // [ForeignKey("User")]
        [Key]
        public int UserDataId { get; set; }
        [MaxLength(100)]
        [Required]
        [Index(name: "UniqueName", IsUnique = true)]
        public string Login { get; set; }
        [MaxLength(12)]
        [Required]
        public string Password { get; set; }
        public string UserAvatarUrl { get; set; }
        public string UserMail { get; set; }
        public virtual User User { get; set; }
        public Professions Profession { get; set; }
        [Required]
        public SexEnum Sex { get; set; }
        [Required]
        public StatesEnum StateId { get; set; }
    }
}
