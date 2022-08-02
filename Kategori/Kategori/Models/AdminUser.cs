using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kategori.Models
{
    public class AdminUser
    {
        [Key]
        public int AdminUserID { get; set; }
        public string AdminUserName { get; set; }
        public string AdminUserMail { get; set; }
        public string AdminUserPassword { get; set; }
    }
}
