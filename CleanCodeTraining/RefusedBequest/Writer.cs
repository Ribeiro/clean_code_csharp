using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeTraining.RefusedBequest
{
    public class Writer : AbstractReaderWriter
    {
        public override void read()
        {
            //I don´t need this method  :(  OMG!
        }

        public override void write()
        {
            Console.WriteLine("Writing ...");
        }
    }
}
