/*
* Luisalberto Castaneda
* 12/07/2021
* ITSE 1430
*/

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Nile
{
    public static class ObjectValidator
    {
        public static IEnumerable<ValidationResult> TryValidate ( IValidatableObject instance )
        {
            var error = new List<ValidationResult>();
            var context = new ValidationContext(instance);

            Validator.TryValidateObject(instance, context, error, true);

            return error;
        }

        public static bool TryValidate ( IValidatableObject instance, out string error )
        {
            var errors = TryValidate(instance);
            error = errors.FirstOrDefault()?.ErrorMessage;

            return String.IsNullOrEmpty(error);
        }

        public static void Validate ( IValidatableObject instance )
        {
            var context = new ValidationContext(instance);
            Validator.ValidateObject(instance, context, true);
        }
    }
}
