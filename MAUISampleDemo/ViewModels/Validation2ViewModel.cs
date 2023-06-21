using MAUISampleDemo.Helpers.Validations;
using MAUISampleDemo.Model;
using Plugin.ValidationRules;
using Plugin.ValidationRules.Extensions;

namespace MAUISampleDemo.ViewModels
{
    public class Validation2ViewModel: ExtendedPropertyChanged
    {
        public Validation2ViewModel()
        {
            _user = new Validatable<UserValidation>();
            _user.Value = new UserValidation();

            AddValidations();
        }

        private Validatable<UserValidation> _user;
        public Validatable<UserValidation> User
        {
            get => _user;
            set => SetProperty(ref _user, value);
        }

        private void AddValidations()
        {
            // Your validations goes here
            _user.Validations.Add(new UserRule());
        }

        public bool Validate()
        {
            // Your logic goes here
            return User.Validate();
        }
    }
}
