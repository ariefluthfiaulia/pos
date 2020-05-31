using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace POS.WebApp.Data
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(30)]
        public string Username { get; set; }
        [StringLength(30)]
        public string Name { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        [ForeignKey("UserRoleId")]
        public UserRole UserRole { get; set; }
        public int UserRoleId { get; set; }
        public bool Gender { get; set; }
        [StringLength(30)]
        public string PhoneNumber { get; set; }
        [StringLength(30)]
        public string CreatedBy { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        [StringLength(30)]
        public string UpdatedBy { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }

    }
}
