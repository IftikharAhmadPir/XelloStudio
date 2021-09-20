using System;
using System.Collections.Generic;

#nullable disable

namespace Xello.DataLayer.Models
{
    public partial class UserCredential
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
