using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace P_CustomAttribute.CustomAttribute;

/// <summary>
/// if we set AttributeTargets as Class then the custom attribute must be use upon class.
/// as here we set AttributeTargets as Property so it must be use upon property.
/// </summary>
[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
public class RequiresCapitalLetterAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object value, ValidationContext validationContext)
    {
        if (value == null)
            return ValidationResult.Success;

        if(value.GetType() == typeof(string))
        {
            if (!string.IsNullOrEmpty(value.ToString()) && !value.ToString().Any(char.IsUpper))
            {
                return new ValidationResult($"The property '{value}' must contain at least one capital letter.");
            }
        }

        if (value.GetType().IsClass && value.GetType() != typeof(string))
        {
            var stringProperties = value.GetType()
                            .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                            .Where(p => p.PropertyType == typeof(string));

            foreach (var prop in stringProperties)
            {
                var propValue = prop.GetValue(value) as string;

                if (!string.IsNullOrEmpty(propValue) && !propValue.Any(char.IsUpper))
                {
                    return new ValidationResult($"The property '{prop.Name}' must contain at least one capital letter.");
                }
            }
        }

        return ValidationResult.Success;
    }
}
