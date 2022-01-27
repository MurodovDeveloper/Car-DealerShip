﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuildCars.UI.Models
{
    public class EditUserViewModel
    {
        public ApplicationUser User { get; set; }
        public IEnumerable<SelectListItem> Roles { get; set; }
        public string UserId { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmPassword { get; set; }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();

            if (String.IsNullOrEmpty(User.FirstName))
            {
                errors.Add(new ValidationResult("First name is required."));
            }
            if (String.IsNullOrEmpty(User.LastName))
            {
                errors.Add(new ValidationResult("Last name is required."));
            }
            if (String.IsNullOrEmpty(User.FirstName))
            {
                errors.Add(new ValidationResult("Email is required."));
            }

            if (!String.IsNullOrEmpty(NewPassword) || !String.IsNullOrEmpty(ConfirmPassword))
            {
                if (NewPassword != ConfirmPassword)
                {
                    errors.Add(new ValidationResult("Passwords to not match."));
                }
            }
            return errors;
        }
    }
}