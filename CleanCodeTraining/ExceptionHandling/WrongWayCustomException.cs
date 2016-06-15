using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanCodeTraining.ExceptionHandling
{
    public class WrongWayCustomException : Exception
    {
        private string Message;

        public WrongWayCustomException(string message)
            : base(message)
        {

        }
    }
}
