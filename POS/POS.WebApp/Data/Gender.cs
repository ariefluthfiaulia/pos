using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.WebApp.Data
{
    public class Gender
    {
        public Gender()
        {
            this.User = new HashSet<User>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short Id { get; set; }
        [StringLength(30)]
        public string Name { get; set; }
        [InverseProperty("Gender")]
        public ICollection<User> User { get; set; }
    }
}
