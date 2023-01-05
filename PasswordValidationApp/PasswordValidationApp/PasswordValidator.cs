using System;

namespace PasswordValidationApp
{
    public class PasswordValidator
    {
        public string Password { get; set; }

        //Default constructor.
        public PasswordValidator() { }
        public PasswordValidator(string pass)
        {
            Password = pass;
        }

        //1. - password should be larger than 8 chars
        public string LengthValidator()
        {
            if(Password.Length < 8)
            {
                return "Entered password is of less characters. Please enter minimum 8 characters as password.";
            }
            return "";
        }

        //2.	- password should not be null
        public string IsNotNullOrEmpty()
        {
            if (string.IsNullOrEmpty(Password))
            {
                return "Password should not be null or empty.";
            }
            
            return "";
        }       

        //3. one Upper case atleast in string and 4. Lower one case atleast.
        // 5. One number atleast.
        public string UpperLowerNumberValidation()
        {            
            bool uppercaseCharacter = false;
            bool lowerCaseCharacter = false;
            bool number = false;

            foreach (var character in Password)
            {
                if (uppercaseCharacter && lowerCaseCharacter && number)
                {
                    break;
                }
                
                if (number == false && Char.IsDigit(character))
                {
                    number = true;
                    continue;
                }

                if (lowerCaseCharacter == false && Char.IsLower(character))
                {
                    lowerCaseCharacter = true;
                    continue;
                }

                if (uppercaseCharacter == false && Char.IsUpper(character))
                {
                    uppercaseCharacter = true;
                    continue;
                }               
            }

            if (lowerCaseCharacter == false)
            {
                return "Password must contain atleast one lowercase character";
            }

            if (uppercaseCharacter == false)
            {
                return "Password must contain atleast one uppercase character";
            }

            if (number == false)
            {
                return "Password must contain atleast one number";
            }

            return "";
        }        
    }
}
