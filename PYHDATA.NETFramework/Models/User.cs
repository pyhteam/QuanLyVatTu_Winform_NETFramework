using PYHDATA.NETFramework.Util;
using System;

namespace PYHDATA.NETFramework.Models
{
    public class User : BaseEnitty
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Image { get; set; }
        public string Password { get; set; }
        public ERole Role { get; set; }
        public EStatus Status { get; set; }

    }
}
