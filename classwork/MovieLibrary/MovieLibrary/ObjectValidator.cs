using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    public static class ObjectValidator
    {
        public static IEnumerable<ValidationResult> TryValidate ( object instance )
        {
            var errors = new List<ValidationResult>();
            var context = new ValidationContext(instance);

            Validator.TryValidateObject(instance, context, errors, true);

            return errors;
        }

        public static bool TryValidate ( object instance, out string error)
        {
            var errors = TryValidate(instance);
            error = errors.FirstOrDefault()?.ErrorMessage;

            return String.IsNullOrEmpty(error);
        }

        public static void Validate ( object instance )
        {
            var context = new ValidationContext(instance);
            Validator.ValidateObject(instance, context, true);
        }
    }
}
