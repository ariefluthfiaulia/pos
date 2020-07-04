using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace POS.WebApp.Dtos.User
{
    public class UserRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "You must specify password between 4 and 8 characters")]
        public string Password { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int UserRoleId { get; set; }
        [Required]
        public short GenderId { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
    }
}
