using App.Application.ViewModels.Contacts;
using App.Data.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace App.Application.ViewModels.Users
{
    public class UserViewModel
    {
        public string Id { get; set; }

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

        public string PhoneNumber { get; set; }

        [ProtectedPersonalData]
        public string Email { get; set; }

        [ProtectedPersonalData]
        public string UserName { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ContactViewModel Contact { get; set; }
    }
}