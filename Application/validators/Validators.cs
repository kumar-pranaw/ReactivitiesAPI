using FluentValidation;

namespace Application.validators
{
    public static class Validators
    {
        public static IRuleBuilder<T, string> Password<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            var options = ruleBuilder
                                .NotEmpty()
                                .MinimumLength(6).WithMessage("Passwod must have atleast 6 characters")
                                .Matches("[A-Z]").WithMessage("Password must contain 1 uppercae letter")
                                .Matches("[a-z]").WithMessage("Password must contain 1 lowercase letter")
                                .Matches("[0-9]").WithMessage("Password must contain a number")
                                .Matches("[^a-zA-Z0-9]").WithMessage("Password must contain non alphanumeric");

            return options;
        }
    }
}