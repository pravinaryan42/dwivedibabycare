﻿
using FluentValidation;
using RKD.Web.Models;

namespace RKD.Web.Code.Validation
{
    public class LoginValidator : AbstractValidator<UserLoginViewModel>
    {
        public LoginValidator()
        {
            RuleFor(x => x.Password).NotNull().WithMessage("*required");
            RuleFor(x => x.Email).EmailAddress().NotNull().WithMessage("*required");            
         
            
        }
    }
}