using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class ExceptionArgs
    {
        public readonly string message;
        public readonly int maxLength;
        public ExceptionArgs(string str, int limit)
        {
            maxLength = limit;
            message = str;
        }

    }
    class OverLengthError : ApplicationException
    {
        public readonly string err;
        public OverLengthError(ExceptionArgs e)
        {
            err = "There are extra symbols in the message. Make it shorter!";
        }

    }

}
