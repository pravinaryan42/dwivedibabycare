using System;
using System.ComponentModel;

namespace RKD.Web.Models
{
    public class ResetPasswordViewModel
    {
        public Guid Id { get; set; }
        [DisplayName("New Password")]
        public string NewPassword { get; set; }
        [DisplayName("Confirm Password")]
        public string ConfirmPassword { get; set; }
    }
}