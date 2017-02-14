using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetWorkDBModel.userData.professions
{
    public class Professions
    {
        [Key]
        public int ProfessionId { get; set; }
        [Required]
        [Index(name: "UniqueProfession", IsUnique = true)]
        [MaxLength(300)]
        public string ProfessionName { get; set; }
    }
}
