using Plugin.ValidationRules;
using Plugin.ValidationRules.Extensions;
using Plugin.ValidationRules.Formatters;
using Plugin.ValidationRules.Rules;

namespace MAUISampleDemo.ViewModels
{
    public class Validation3ViewModel: ExtendedPropertyChanged
    {
        ValidationUnit _validationUnit;

        public Validation3ViewModel()
        {
            AddValidations();
        }

        public Validatable<string> LastName { get; set; }
        public Validatable<string> Name { get; set; }
        public Validatable<string> Email { get; set; }
        public Validatable<string> Phone { get; set; }

        private void AddValidations()
        {
            Name = new Validatable<string>(
                new NotEmptyRule<string>("").WithMessage("A name is required.")
            );

            LastName = Validator.Build<string>()
                        .IsRequired("A last name is required.")
                        .Must(CustomValidation, "Last name need to be longer.")
                        .When(x => Name.Validate());

            //// You can add several Rules by this
            ///
            //Email = new Validatable<string>(
            //    new IsNotNullOrEmptyRule<string>().WithMessage("A email is required."), 
            //    new EmailRule()
            //);

            // Or this
            Email = Validator.Build<string>()
                    //.Add(new IsNotNullOrEmptyRule<string>(), "An email is required.")
                    .IsRequired("An email is required.")
                    .WithRule(new Helpers.Validations.EmailRule())
                    .When(x => Name.Validate() && LastName.Validate());


            Phone = Validator.Build<string>()
                 .IsRequired("phone no is required.")
                .Must(CustomValidation1, "Minimum lenght is 12.");

            Phone.Formatter = new MaskFormatter("XXX-XXX-XXXX");

            // Add to the unit
            _validationUnit = new ValidationUnit(Name, LastName, Email,Phone);
        }

        public bool Validate()
        {
            return _validationUnit.Validate();
        }

        private bool CustomValidation(string parameter)
        {
            return parameter?.Length > 3;
        }

        private bool CustomValidation1(string parameter)
        {
            return parameter?.Length == 12;
        }
    }
}

