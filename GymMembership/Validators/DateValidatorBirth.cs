using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using GymMembership.Models;

namespace GymMembership.Validators
{
    public class DateValidatorBirth : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            if (customer.MembershipTypeId == 1)
                return ValidationResult.Success;

            if (customer.Birthdate == null)
                return new ValidationResult("Gimimo data reikalinga.");

            var age = DateTime.Today.Year - customer.Birthdate.Value.Year;

            return (age >= 18 && customer.Birthdate < customer.CustomerSinceDate) 
                ? ValidationResult.Success 
                : new ValidationResult("Klientas nepilnametis arba netinkama abonemento data netinka.");
        }
    }
}