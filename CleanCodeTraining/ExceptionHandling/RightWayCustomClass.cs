using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeTraining.ExceptionHandling
{
    public class RightWayCustomClass
    {
        // http://www.codeproject.com/Articles/9538/Exception-Handling-Best-Practices-in-NET

        ILog log = LogManager.GetLogger(typeof(RightWayCustomClass));

        public void DoNothing()
        {
            try
            {
                if (true)
                {
                    throw new RightWayCustomException("This is my exception customized message!");
                }

            }
            catch (RightWayCustomException e)
            {
                log.Error("Something went wrong", e); //Option 1 - Without exception handling. Only logging
                throw new RightWayInnerCustomException("My Exception message!", e); //Option 2 - Rethrow encapsulating original exception within
            }


        }
    }
}
