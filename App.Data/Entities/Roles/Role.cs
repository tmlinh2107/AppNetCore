using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Data.Entities.Roles
{
    [Table("Roles")]
    public class Role : IdentityRole<Guid>
    {
        public Role() : base()
        {
        }

        public Role(string name, string description) : base(name)
        {
            Description = description;
        }

        [StringLength(250)]
        public string Description { get; set; }
    }
}