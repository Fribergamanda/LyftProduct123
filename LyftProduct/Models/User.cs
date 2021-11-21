using System;
using System.Collections.Generic;

#nullable disable

namespace LyftProduct.Models
{
    public partial class User
    {
        public User()
        {
            UserAddresses = new HashSet<UserAddress>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public virtual ICollection<UserAddress> UserAddresses { get; set; }
    }
}
