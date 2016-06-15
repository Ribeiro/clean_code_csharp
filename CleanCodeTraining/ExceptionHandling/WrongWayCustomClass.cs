using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeTraining.ExceptionHandling
{
    public class WrongWayCustomClass
    {

        public void DoNothing()
        {
            try
            {
                if (true)
                {
                    throw new Exception();
                }

            }
            catch (Exception e)
            {
                
                throw new WrongWayCustomException(e.Message);
            }

            
        }
    }
}
