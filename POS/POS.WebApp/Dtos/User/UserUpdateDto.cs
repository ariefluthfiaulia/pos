using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POS.WebApp.Dtos.User
{
    public class UserUpdateDto
    {
        public string Username { get; set; }
        public string Name { get; set; }
        public int UserRoleId { get; set; }
        public short GenderId { get; set; }
        public string PhoneNumber { get; set; }
    }
}
