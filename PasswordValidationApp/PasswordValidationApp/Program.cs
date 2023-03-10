using System;

/*
 * Problem statement 2: Password Validation
We like to build code for purposes of password verification. Verification will fail if any one
of the rules mentioned does not pass.
1. Implement the following rules. Each one of these will throw an exception with a
different message of your choice
1. - password should be larger than 8 chars
2. - password should not be null
3. - password should have one uppercase letter at least
4. - password should have one lowercase letter at least
5. - password should have one number at least
2. Add feature: Password is OK if at least three of the previous conditions is true
3. Add feature: password is never OK if item 1.d is not true.
4. Assume Each verification takes 1 second to complete. How would you solve items 2
and 3 so tests can run faster?
 */

namespace PasswordValidationApp
{
    //Inherits Validator Class (this does most of validations which can be extended or
    // we can make ValidatorClass as interface without body)
    public class ValidatorClass : PasswordValidator
    {       
        public bool ValidatePassword(string strPassword)
        {
            //Inherit Validate Parent class
            PasswordValidator validator = new PasswordValidator(strPassword);
            if (string.Compare(validator.LengthValidator(), "") != 0)
            {
                Console.WriteLine(validator.LengthValidator());
                return false;
            }

            if (string.Compare(validator.IsNotNullOrEmpty(), "") != 0)
            {
                Console.WriteLine(validator.IsNotNullOrEmpty());
                return false;
            }

            if (string.Compare(validator.UpperLowerNumberValidation(), "") != 0)
            {
                Console.WriteLine(validator.UpperLowerNumberValidation());
                return false;
            }

            return true;
        }
    }

    class ProgramMain {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Input password as per defined set of rules");
            string strPasswordRead = Console.ReadLine();
            ValidatorClass validatorClass = new ValidatorClass();
            validatorClass.ValidatePassword(strPasswordRead);
        }
    }
    
}
