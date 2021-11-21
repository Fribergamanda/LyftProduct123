using System;
using System.Collections.Generic;

#nullable disable

namespace LyftProduct.Models
{
    public partial class Address
    {
        public Address()
        {
            UserAddresses = new HashSet<UserAddress>();
        }

        public int Id { get; set; }
        public string AddressLine { get; set; }
        public short? HouseNr { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }

        public virtual ICollection<UserAddress> UserAddresses { get; set; }
    }
}
