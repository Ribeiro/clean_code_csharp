using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanCodeTraining.ExceptionHandling
{
    [Serializable]
    public class RightWayInnerCustomException : Exception
    {
        private Exception Exception;
        private string Message;

        public RightWayInnerCustomException(string message, RightWayCustomException exception) : base(message, exception)
        {
           
        }

    }

}
