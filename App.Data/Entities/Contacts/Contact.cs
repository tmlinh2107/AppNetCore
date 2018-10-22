using App.Data.DomainEntity;
using App.Data.Entities.Users;
using System.Collections.Generic;

namespace App.Data.Entities.Contacts
{
    public class Contact : EntityBase<int>
    {
        public string Address { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public bool IsDefault { get; set; }
        public int UserId { get; set; }

        public virtual ICollection<User> User { get; set; }
    }
}