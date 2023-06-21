﻿using MAUISampleDemo.Helpers.Validations;
using Plugin.ValidationRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUISampleDemo.ViewModels
{
    public class ValidationRulesViewModel
    {
        ValidationUnit _unit1;

        public ValidationRulesViewModel()
        {
            Name = new Validatable<string>();
            LastName = new Validatable<string>();
            Email = new Validatable<string>();

            _unit1 = new ValidationUnit(Name, LastName, Email);

            AddValidations();
        }

        public Validatable<string> LastName { get; set; }
        public Validatable<string> Name { get; set; }
        public Validatable<string> Email { get; set; }


        private void AddValidations()
        {
            // Name validations
            Name.Validations.Add(new IsNotNullOrEmptyRule<string> { ValidationMessage = "A name is required." });

            //Lastname validations
            LastName.Validations.Add(new IsNotNullOrEmptyRule<string> { ValidationMessage = "A lastname is required." });

            //Email validations
            Email.Validations.Add(new IsNotNullOrEmptyRule<string> { ValidationMessage = "A email is required." });
            Email.Validations.Add(new EmailRule());
        }

        public bool Validate()
        {
            //var isValidName = _name.Validate();
            //var isValidLastname = _lastname.Validate();
            //var isValidEmail = _email.Validate();

            //return isValidName && isValidLastname && isValidEmail;
            return _unit1.Validate();
        }

    }
}
