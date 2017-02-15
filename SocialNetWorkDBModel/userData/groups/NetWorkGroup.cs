using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetWorkDBModel.userData.groups
{
    public class NetWorkGroup
    {
        [Key]
        public int GroupId { get; set; }

        public ICollection<User> Users { get; set; } 
    }
}
