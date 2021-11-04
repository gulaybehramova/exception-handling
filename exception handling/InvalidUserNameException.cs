using System;
using System.Collections.Generic;
using System.Text;

namespace exception_handling
{
    class InvalidUserNameException:Exception
    {
        public InvalidUserNameException(string msj) : base(msj)
        {

        }
       
    }
}
