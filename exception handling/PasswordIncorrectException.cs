using System;
using System.Collections.Generic;
using System.Text;

namespace exception_handling
{
    public class PasswordIncorrectException : Exception
    {
        public PasswordIncorrectException(string msj) : base(msj)
        {

        }
    }
}
