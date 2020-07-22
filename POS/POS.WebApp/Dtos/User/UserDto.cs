using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POS.WebApp.Dtos.User
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string UserRole { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
    }
}
