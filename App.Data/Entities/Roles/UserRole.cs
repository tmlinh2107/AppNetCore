using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Data.Entities.Roles
{
    [Table("UserRoles")]
    public class UserRole : IdentityUserRole<Guid>
    {
        public UserRole() : base()
        {

        }
    }
}