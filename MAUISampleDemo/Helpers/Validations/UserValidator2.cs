using MAUISampleDemo.Model;
using Plugin.ValidationRules;
using Plugin.ValidationRules.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUISampleDemo.Helpers.Validations
{
    public class UserValidator2 : Validator<UserValidation>
    {
        public UserValidator2()
        {
            //Name validations
            Name = Build<string>()
                    .WithRule(new IsNotNullOrEmptyRule<string>(), "A name is required.");

            //Lastname validations
            LastName = Build<string>()
                        .WithRule(new IsNotNullOrEmptyRule<string>(), "A lastname is required.");

            //Email validations
            Email = Build<string>()
                        .IsRequired("A email is required.")
                        .WithRule(new EmailRule());

            InitUnit();
        }

        public Validatable<string> LastName { get; set; }
        public Validatable<string> Name { get; set; }
        public Validatable<string> Email { get; set; }

        //public override bool Validate()
        //{
        //    Your logic goes here
        //    return _unit1.Validate();
        //}

        public override UserValidation Map()
        {
            // Simple Manual Mapper
            var manualMapperUser = new UserValidation
            {
                Name = this.Name.Value,
                LastName = this.LastName.Value,
                Email = this.Email.Value
            };

            return manualMapperUser;
        }
    }
}
