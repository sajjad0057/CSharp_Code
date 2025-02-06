

using System.ComponentModel.DataAnnotations;

namespace P_CustomAttribute;

public static class ModelValidator
{
    public static List<ValidationResult> ValidateModel(object model)
    {
        var validationResults = new List<ValidationResult>();
        var validationContext = new ValidationContext(model, null, null);

        Validator.TryValidateObject(model, validationContext, validationResults, validateAllProperties: true);
        return validationResults;
    }
}
