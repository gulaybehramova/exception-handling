using System;
using System.Collections.Generic;
using System.Text;
using exception_handling;
using ClassLibrary;

namespace exception_handling
{
    public class User
    {
        Check check = new Check();

        private string _username;
        private string _paswword;

        public string UserName
        {
            get
            {
                return _username;
            }
            set
            {
                if (value.Length < 6 || value.Length > 25)
                {
                    throw new InvalidUserNameException("Uygun olmayan bir deyer set olunub.");
                }
                else
                {
                    _username = value;
                }
            }
        }

        public string Password
        {
            get
            {
                return _paswword;
            }
            set
            {
                if (value.Length < 8 || value.Length > 25 || !check.HasDigit(value) || !check.HasLower(value) || !check.HasUpper(value))
                {
                    throw new PasswordIncorrectException("Uygun olmayan Password deyeri.");
                }
                else
                {
                    _paswword = value;
                }
            }
        }
    }

}