﻿using Microsoft.AspNetCore.Identity;

namespace CoSmellRefine.Models.ViewModels
{
    public class UserViewModel
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }

        public IEnumerable<IdentityRole> Roles { get; set; }
    }
}
