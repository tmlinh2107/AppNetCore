using App.Data.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Data.Entities.Users
{
    [Table("Users")]
    public class User : IdentityUser<Guid>
    {
        public User()
        {
            CreatedDate = DateTime.UtcNow;
        }

        public User(
            string firstName, 
            string lastName, 
            DateTime? birthday, 
            string avartarUrl, 
            UserStatus status, 
            DateTime createdDate, 
            DateTime? modifiedDate)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthday;
            AvartarUrl = avartarUrl;
            Status = status;
            CreatedDate = createdDate;
            ModifiedDate = modifiedDate;
        }

        [PersonalData]
        [StringLength(500)]
        public string FirstName { get; set; }

        [PersonalData]
        [StringLength(500)]
        public string LastName { get; set; }

        [PersonalData]
        public DateTime? Birthday { get; set; }

        [PersonalData]
        public string AvartarUrl { get; set; }

        public UserStatus Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}