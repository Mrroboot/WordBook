using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using WordBook.BE;
using WordBook.DA;

namespace WordBook.BL
{
    public class BLSourceDefinition
    {
        public DataSet GetSourceFileDefini(BESourceDefinition sourceDefiniBE)
        {
            DA.DASourceDefinition sourceDefiniDA = new DA.DASourceDefinition();
            return sourceDefiniDA.GetSourceFileDefini(sourceDefiniBE);
        }
    }
}
