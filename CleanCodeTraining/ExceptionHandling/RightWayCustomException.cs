using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanCodeTraining.ExceptionHandling
{
    [Serializable]
    public class RightWayCustomException : Exception
    {
        private string Message;

        public RightWayCustomException(string message)
            : base(message)
        {

        }
    }
}
