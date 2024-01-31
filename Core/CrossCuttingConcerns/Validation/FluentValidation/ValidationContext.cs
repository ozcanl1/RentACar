namespace Core.CrossCuttingConcerns.Validation.FluentValidation
{
    internal class ValidationContext<T>
    {
        private object objectToValidate;

        public ValidationContext(object objectToValidate)
        {
            this.objectToValidate = objectToValidate;
        }
    }
}