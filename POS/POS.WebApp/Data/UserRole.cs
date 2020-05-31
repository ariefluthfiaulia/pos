using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace POS.WebApp.Data
{
    public class UserRole
    {
        public UserRole()
        {
            this.User = new HashSet<User>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(30)]
        public string Name { get; set; }
        [StringLength(30)]
        public string CreatedBy { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        [StringLength(30)]
        public string UpdatedBy { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }

        [InverseProperty("UserRole")]
        public ICollection<User> User { get; set; }
    }
}
