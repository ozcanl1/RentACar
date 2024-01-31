
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Validation.FluentValidation
{
    public static class ValdationTool
    {
        public static void Validate(IValidator validator, object objectToValidate)
        {
            ValidationContext<object> context = new(objectToValidate);// ilgili nesneyi validate etmek için tanımlandı
            var result = validator.Validate(context);//ilgili validator ile ilgili nesneyi validate ediyoruz

            if (!result.IsValid)
                throw new ValidationException(result.Errors);
        }
    }
}
