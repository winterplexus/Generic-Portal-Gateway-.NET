﻿//
//  LoginViewModel.cs
//
//  Wiregrass Code Technology 2017
//
using System.ComponentModel.DataAnnotations;

namespace PortalGateway
{
    public class LoginViewModel
    {
        [Display(Name = "User ID")]
        public string UserId { get; set; }

        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}