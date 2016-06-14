using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanCodeTraining.model
{
    class InsufficientFundsException : Exception
    {
        private string Message;

        public InsufficientFundsException(string message)
            : base(message)
        {

        }


    }

}
