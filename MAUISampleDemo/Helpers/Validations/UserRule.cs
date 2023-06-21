using MAUISampleDemo.Model;
using Plugin.ValidationRules.Interfaces;
using System.Text.RegularExpressions;

namespace MAUISampleDemo.Helpers.Validations
{
    public class UserRule : IValidationRule<UserValidation>
    {
        public string ValidationMessage { get; set; }

        public bool Check(UserValidation value)
        {
            if (value == null)
            {
                throw new Exception();
            }

            if (string.IsNullOrEmpty(value.Name))
            {
                ValidationMessage = "A name is required.";
                return false;
            }

            if (string.IsNullOrEmpty(value.LastName))
            {
                ValidationMessage = "A last name is required.";
                return false;
            }


            if (string.IsNullOrEmpty(value.Email))
            {
                ValidationMessage = "A email is required.";
                return false;
            }

            var str = value.Email as string;

            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(str);

            if (!match.Success)
            {
                ValidationMessage = "Email is not valid.";
                return false;
            }

            return true; // Yupiii !!!
        }
    }
}
